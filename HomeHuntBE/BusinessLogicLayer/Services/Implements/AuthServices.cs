using BusinessLogicLayer.RequestModels;
using BusinessLogicLayer.ResponseModels;
using DataAccessLayer.Models;
using DataAccessLayer.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mail;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using DataAccessLayer.Tools;

namespace BusinessLogicLayer.Services.Implements
{
    public class AuthServices : IAuthServices
    {
        private readonly IUsersService _userService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;


        public AuthServices(IUsersService userService, IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _userService = userService;
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<BaseResponseForLogin<LoginResponseModel>> AuthenticateAsync(string username, string password)
        {
            var user = await _userService.GetUserByUsernameAsync(username);

            if (user != null)
            {
                if (user.Status == false)
                {
                    return new BaseResponseForLogin<LoginResponseModel>()
                    {
                        Code = 404,
                        Message = "Your Account has been banned. Check email for reason",
                        Data = new LoginResponseModel()
                        {
                            User = new UsersResponseModel()
                            {
                                Id = user.Id,
                                FullName = user.FullName,
                                Email = user.Email,
                                Dob = user.Dob,
                                Address = user.Address,
                                Phone = user.PhoneNumber,
                                Gender = user.Gender
                            },
                        },
                        IsBanned = true,
                    };
                }

                var userWithRole = await _userService.GetUserByFullNameAsync(user.FullName);
                string token = GenerateJwtToken(user.FullName, userWithRole.Role.Name, user.Id);

                return new BaseResponseForLogin<LoginResponseModel>()
                {
                    Code = 200,
                    Message = "",
                    Data = new LoginResponseModel()
                    {
                        Token = token,
                        User = new UsersResponseModel()
                        {
                            Id = user.Id,
                            FullName = user.FullName,
                            Email = user.Email,
                            Dob = user.Dob,
                            Address = user.Address,
                            Phone = user.PhoneNumber,
                            Gender = user.Gender
                        },
                    },
                    IsBanned = false
                };
            }
            return new BaseResponseForLogin<LoginResponseModel>()
            {
                Code = 404,
                Message = "Username or Password incorrect",
                Data = null,
                IsBanned = false
            };
        }



        public async Task<BaseResponse<TokenModel>> RegisterAsync(RegisterModel registerModel)
        {

            var existingUser = await _userService.GetUserByUsernameAsync(registerModel.Username);

            if (existingUser != null)
            {
                return new BaseResponse<TokenModel>
                {
                    Code = 409,
                    Message = "Username already exists",
                };
            }
            var role = await _unitOfWork.Repository<Role>().FindAsync(r => r.Name == "Customer");

            var user = new User()
            {
                Id = Guid.NewGuid(),
                RoleId = role.Id,
                Username = registerModel.Username,
                FullName = registerModel.FullName,
                Password = PasswordTools.HashPassword(registerModel.Password),
                PhoneNumber = registerModel.PhoneNumber,
                Status = true,
            };

            await _unitOfWork.Repository<User>().InsertAsync(user);
            await _unitOfWork.CommitAsync();

            var userWithRole = await _userService.GetUserByFullNameAsync(user.FullName);
            string token = GenerateJwtToken(user.FullName, userWithRole.Role.Name, user.Id);

            return new BaseResponse<TokenModel>
            {
                Code = 201,
                Message = "Register successfully",
                Data = new TokenModel
                {
                    Token = token
                }
            };
        }

        public async Task<BaseResponse<TokenModel>> AdminGenAcc(AdminCreateAccountModel adminCreateAccountModel)
        {
            var existingUser = await _unitOfWork.Repository<User>().FindAsync(u => u.Email == adminCreateAccountModel.Email);

            if (existingUser != null)
            {
                return new BaseResponse<TokenModel>
                {
                    Code = 409,
                    Message = "Email already exists",
                };
            }

            var user = new User()
            {
                //Address = adminCreateAccountModel.Address,
                //FullName = adminCreateAccountModel.FullName,
                //Email = adminCreateAccountModel.Email,
                //Password = "01234",
                //Gender = adminCreateAccountModel.Gender,
                //Dob = adminCreateAccountModel.Dob,
                //PhoneNumber = adminCreateAccountModel.PhoneNumber,
                //Status = true,
            };

            await _unitOfWork.Repository<User>().InsertAsync(user);
            await _unitOfWork.CommitAsync();

            await SendAccount(user.Id);

            var userWithRole = await _userService.GetUserByFullNameAsync(user.FullName);
            string token = GenerateJwtToken(user.FullName, userWithRole.Role.Name, user.Id);

            return new BaseResponse<TokenModel>
            {
                Code = 201,
                Message = "Register successfully",
                Data = new TokenModel
                {
                    Token = token
                }
            };
        }

        public async Task<BaseResponse> SendAccount(Guid userId)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(userId);
                var providePassword = PasswordTools.GeneratePassword();
                user.Password = PasswordTools.HashPassword(providePassword);
                await _unitOfWork.Repository<User>().UpdateGuid(user, user.Id);
                await _unitOfWork.CommitAsync();

                var smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("studentexchangeweb@gmail.com", "fwpl wpkw zhqe peyh");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("studentexchangeweb@gmail.com");
                mailMessage.To.Add(user.Email);
                mailMessage.Subject = "YOUR ENTRY ACCOUNT";

                mailMessage.Body = @"
<html>
<head>
  <style>
    body {
      font-family: Arial, sans-serif;
      line-height: 1.6;
    }
    .container {
      padding: 20px;
      background-color: #f4f4f4;
      border: 1px solid #ddd;
      border-radius: 5px;
      max-width: 600px;
      margin: 0 auto;
    }
    .header {
      font-size: 20px;
      font-weight: bold;
      text-align: center;
      margin-bottom: 20px;
    }
    .content {
      font-size: 16px;
      color: #333;
    }
    .footer {
      font-size: 12px;
      color: #888;
      text-align: center;
      margin-top: 20px;
    }
    .highlight {
      color: #007BFF;
      font-weight: bold;
    }
  </style>
</head>
<body>
  <div class='container'>
    <div class='header'>Welcome to our Exchange Web!</div>
    <div class='content'>
      <p>Email: <span class='highlight'>" + user.Email + @"</span></p>
      <p>Password: <span class='highlight'>" + providePassword + @"</span></p>
      <p>This is a temporary password. Please change your password after logging in.</p>
    </div>
    <div class='footer'>
      &copy; 2024 Exchange Web. All rights reserved.
    </div>
  </div>
</body>
</html>";

                mailMessage.IsBodyHtml = true;

                await smtpClient.SendMailAsync(mailMessage);

                return new BaseResponse
                {
                    Code = 200,
                    Message = "Send succeed."
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse
                {
                    Code = 400,
                    Message = "An error occurred: " + ex.Message
                };
            }
        }

        public async Task<BaseResponse> ForgotPassword(ForgotPasswordRequest request)
        {
            try
            {
                var query = await _unitOfWork.Repository<User>()
                    .AsNoTracking()
                    .SingleOrDefaultAsync(x => x.Email == request.Email);

                if (query == null || query.Email != request.Email)
                {
                    return new BaseResponse
                    {
                        Code = StatusCodes.Status400BadRequest,
                        Message = "Email is not matched"
                    };
                }

                var providePassword = PasswordTools.GeneratePassword();
                query.Password = PasswordTools.HashPassword(providePassword);

                var smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("studentexchangeweb@gmail.com", "fwpl wpkw zhqe peyh");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("studentexchangeweb@gmail.com");
                mailMessage.To.Add(query.Email);
                mailMessage.Subject = "WEB EXCHANGE: YOUR RESET PASSWORD";

                mailMessage.Body = @"
<html>
<head>
  <style>
    body {
      font-family: Arial, sans-serif;
      line-height: 1.6;
    }
    .container {
      padding: 20px;
      background-color: #f4f4f4;
      border: 1px solid #ddd;
      border-radius: 5px;
      max-width: 600px;
      margin: 0 auto;
    }
    .header {
      font-size: 20px;
      font-weight: bold;
      text-align: center;
      margin-bottom: 20px;
    }
    .content {
      font-size: 16px;
      color: #333;
    }
    .footer {
      font-size: 12px;
      color: #888;
      text-align: center;
      margin-top: 20px;
    }
    .highlight {
      color: #007BFF;
      font-weight: bold;
    }
  </style>
</head>
<body>
  <div class='container'>
    <div class='header'>Password Reset Request</div>
    <div class='content'>
      <p>Hello <span class='highlight'>" + query.FullName + @"</span>,</p>
      <p>Your reset password is: <span class='highlight'>" + providePassword + @"</span></p>
      <p>This is a temporary password. Please change your password after logging in.</p>
    </div>
    <div class='footer'>
      &copy; 2024 Exchange Web. All rights reserved.
    </div>
  </div>
</body>
</html>";

                mailMessage.IsBodyHtml = true;

                await smtpClient.SendMailAsync(mailMessage);
                await _unitOfWork.Repository<User>().UpdateGuid(query, query.Id);
                await _unitOfWork.CommitAsync();

                return new BaseResponse
                {
                    Code = StatusCodes.Status200OK,
                    Message = "Your reset password has been sent."
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse
                {
                    Code = StatusCodes.Status500InternalServerError,
                    Message = "An error occurred: " + ex.Message
                };
            }
        }

        public string GenerateJwtToken(string username, string roleName, Guid userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, roleName),
                    new Claim(ClaimTypes.NameIdentifier, userId.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
