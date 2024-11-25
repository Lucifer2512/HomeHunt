using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    PostTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bedrooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bathrooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FurnitureCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("post_id_primary", x => x.Id);
                    table.ForeignKey(
                        name: "post_userid_foreign",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionCode = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("transaction_id_primary", x => x.Id);
                    table.ForeignKey(
                        name: "post_transactionid_foreign",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "transaction_userid_foreign",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), new DateTime(2024, 11, 25, 2, 27, 19, 76, DateTimeKind.Utc).AddTicks(9291), "Admin", null, new DateTime(2024, 11, 25, 2, 27, 19, 76, DateTimeKind.Utc).AddTicks(9301) },
                    { new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), new DateTime(2024, 11, 25, 2, 27, 19, 76, DateTimeKind.Utc).AddTicks(9304), "Customer", null, new DateTime(2024, 11, 25, 2, 27, 19, 76, DateTimeKind.Utc).AddTicks(9305) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedDate", "Dob", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("7ac5986b-020a-410e-81d2-0d1732f3fde6"), null, new DateTime(2024, 11, 25, 2, 27, 19, 80, DateTimeKind.Utc).AddTicks(915), null, null, "Customer ", null, "E8/wh6eKvRSrpWv20iuuJfHafGJoKhNpRBUNLgQDmSHQZXRl", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 25, 2, 27, 19, 80, DateTimeKind.Utc).AddTicks(924), "Customer" },
                    { new Guid("bb457a69-5c22-49ef-92a2-38bd672c1a02"), null, new DateTime(2024, 11, 25, 2, 27, 19, 76, DateTimeKind.Utc).AddTicks(9452), null, null, "Admin ", null, "RzqaFqL9mNBQuzwbjOe46TDkpfG65WW/fx5HGkZA26Fa2m61", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 25, 2, 27, 19, 76, DateTimeKind.Utc).AddTicks(9453), "Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PostId",
                table: "Transaction",
                column: "PostId",
                unique: true,
                filter: "[PostId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserId",
                table: "Transaction",
                column: "UserId");

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
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
