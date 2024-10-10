using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HomeOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoommId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HomeOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoommId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    District = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("house_id_primary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("role_id_primary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Length = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Width = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Services = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("room_id_primary", x => x.Id);
                    table.ForeignKey(
                        name: "room_houseid_foreign",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("user_id_primary", x => x.Id);
                    table.ForeignKey(
                        name: "user_roleid_foreign",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("post_id_primary", x => x.Id);
                    table.ForeignKey(
                        name: "post_roomid_foreign",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Dob = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("application_id_primary", x => x.Id);
                    table.ForeignKey(
                        name: "application_userid_foreign",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("rating_id_primary", x => x.Id);
                    table.ForeignKey(
                        name: "rating_roomid_foreign",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "rating_userid_foreign",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, "Admin", null, null },
                    { new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, "Customer", null, null }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreatedDate", "Description", "HouseId", "Length", "Name", "Rating", "Services", "Status", "UpdatedDate", "Width" },
                values: new object[] { new Guid("1b9cbb78-8942-4783-8e26-b19e8e7e98c8"), null, "This is a room. Here is some more characters to test the length of the text box", null, "10m", "Temporary Room", null, null, null, null, "5m" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Phone", "Price", "RoomId", "SocialAccount", "Status", "Title", "UpdatedDate" },
                values: new object[] { new Guid("f4c96cab-02bc-462e-b746-7c336daa623d"), null, "This is a post. Here is some more characters to test the length of the text box", "not yet set up", "123456789", 10000m, new Guid("1b9cbb78-8942-4783-8e26-b19e8e7e98c8"), "zalo || fb", null, "Temporary Post", null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedDate", "Dob", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("049b2b54-b2dd-4465-8a64-f8e1158d5649"), null, null, null, "Customer10@email.com", "Customer 10", null, "BGLKy5l67GvuLrdoXEtNq4Zubmq9PA2oxrVlm3uJp9V8oufx", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer10" },
                    { new Guid("07226311-4297-4770-ab15-31226043ef9b"), null, null, null, "Customer7@email.com", "Customer 7", null, "wX/nmetDeuiYEw4ftk3ubD8G81iRIjucA4tzPLqoMytuiDay", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer7" },
                    { new Guid("1104c4c0-6de9-480c-be96-657c793e1d14"), null, null, null, "Customer9@email.com", "Customer 9", null, "lI544DbvdacVtQYbpCC7aKDQufFo/A7MYV76ObwaOnbIXbkN", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer9" },
                    { new Guid("1c54b7b0-ca76-4b60-977f-377c88b4b2f2"), null, null, null, "Customer4@email.com", "Customer 4", null, "8Sqv0U8tCSjuci3ZFJ9iUtq+/nNEJSlXacIhvUG2fLbUOmM9", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer4" },
                    { new Guid("31255bb0-d39a-4bc0-8e04-ecb8953cf894"), null, null, null, "Customer3@email.com", "Customer 3", null, "UIataCcoN+a5Wlpxex3o+vY4sviXJVp6LkCEvGwBHaWySRiy", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer3" },
                    { new Guid("40424a9a-f91b-4f27-830d-eb30b2df9b0b"), null, null, null, "Customer1@email.com", "Customer 1", null, "8qfckl4m1VhpljKFpIAEHzg02GAI9R57mNRVpZHrWbhsoHXs", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer1" },
                    { new Guid("44c716f8-f52e-4f40-8889-068506138059"), null, null, null, "Customer2@email.com", "Customer 2", null, "p8YPG2OSpqzVi+aGgKHkqDVcvq5DCC5QfnlCIRDK08AqINSJ", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer2" },
                    { new Guid("5428c36a-1b59-4da1-a368-984625ac03dd"), null, null, null, "Admin1@email.com", "Admin 1", null, "aqhZuTY3dDT8fPSB0pciFN1daufpI2JNvn563e0PdyLVcx3E", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, null, "Admin1" },
                    { new Guid("58ec66f5-d29c-4f16-aead-db7237017bb3"), null, null, null, "Customer15@email.com", "Customer 15", null, "aU1fxdVE9AG0FI0x1ccYlWl7Yq9WlFpqb3dqBlA532Y6fPTP", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer15" },
                    { new Guid("6a62a9e2-0d6d-4940-890b-b38e4a9d1aa4"), null, null, null, "Customer5@email.com", "Customer 5", null, "nsYXdLcOzYeto1vveQGzxd2qeyQc4jESbU02Fw+M+2MCzQbR", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer5" },
                    { new Guid("811119e4-b69c-4837-ac48-c25c00841d45"), null, null, null, "Customer8@email.com", "Customer 8", null, "AR1/yW15hecjB1yXIeqTMNLkpD2RzqL2cSluyLjguDzLQtn0", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer8" },
                    { new Guid("bbf4670c-51f5-4473-92b1-fbcbf6dfdad0"), null, null, null, "Customer6@email.com", "Customer 6", null, "jgYOIa8Kp9lN6KN93Zr744rU12QJojZPOfbArBeixtTy/izM", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer6" },
                    { new Guid("c4962bb9-f368-4364-b0c4-1c3d2a3ce467"), null, null, null, "Customer12@email.com", "Customer 12", null, "1AzvD0GhmKvmKU3gs2rOU77iCOmjoOTYyoaGOcbDytUCrHwx", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer12" },
                    { new Guid("da34ed35-ca09-443b-9f72-3ad5248276f4"), null, null, null, "Customer14@email.com", "Customer 14", null, "v+BpSEcyj+6axmJFqq0TXI4MoocJhyh/vPqdDqfPHYUV2EyH", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer14" },
                    { new Guid("f4b08629-3b81-48d6-82f3-e6cbc8f8b7d5"), null, null, null, "Admin2@email.com", "Admin 2", null, "A3qTtcrMtUdqyRJrh0rV+rVdcHOGPZucTqx2YJ9hIvPxLJIE", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, null, "Admin2" },
                    { new Guid("f87a4f08-9dba-461a-8dcc-8ecd0f69df26"), null, null, null, "Customer13@email.com", "Customer 13", null, "XcNpA2VfRo5GyfTTy/fpnLyiXVAhdiH+RzE+OGJEkByCTI+K", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer13" },
                    { new Guid("fe740cab-b613-416f-86ab-d157fa442aa6"), null, null, null, "Customer11@email.com", "Customer 11", null, "GY7+M7DBfT30p8qTD5cAqiRgwTOFNx05UAEL9xJ4evv7PBF+", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer11" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_UserID",
                table: "Application",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_RoomId",
                table: "Post",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_RoomId",
                table: "Rating",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_UserId",
                table: "Rating",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HouseId",
                table: "Room",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "user_email_unique",
                table: "User",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "user_Username_unique",
                table: "User",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "House");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
