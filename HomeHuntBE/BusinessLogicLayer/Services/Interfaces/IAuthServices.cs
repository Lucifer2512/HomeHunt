using BusinessLogicLayer.RequestModels;
using BusinessLogicLayer.ResponseModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
	public interface IAuthServices
	{
		Task<BaseResponseForLogin<LoginResponseModel>> AuthenticateAsync(string username, string password);
		Task<BaseResponse<TokenModel>> RegisterAsync(RegisterModel user);
		Task<BaseResponse<TokenModel>> AdminGenAcc(AdminCreateAccountModel adminCreateAccountModel);
		Task<BaseResponse> SendAccount(Guid userId);
		Task<BaseResponse> ForgotPassword(ForgotPasswordRequest request);

    }
}
