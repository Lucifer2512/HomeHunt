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
                    { new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2231), "Admin", null, new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2240) },
                    { new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2244), "Customer", null, new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2244) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedDate", "Dob", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("092be2a9-c8f5-4972-b1d2-fb110af8f029"), null, new DateTime(2024, 11, 24, 23, 6, 42, 148, DateTimeKind.Utc).AddTicks(213), null, null, "Customer 10", null, "StuDtkRqfLWgTVg6iBw4Ra9eLrAp2ZabelKznpIho2/29YOh", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 148, DateTimeKind.Utc).AddTicks(213), "Customer10" },
                    { new Guid("2845c934-4532-420d-8b79-87f0a2af8954"), null, new DateTime(2024, 11, 24, 23, 6, 42, 129, DateTimeKind.Utc).AddTicks(4729), null, null, "Customer 4", null, "0BKpTMwHjRnQloifd31lTJGmFdT8jjXS2Y1vQRT8IlWwpce9", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 129, DateTimeKind.Utc).AddTicks(4730), "Customer4" },
                    { new Guid("32835ef7-d7ab-4c7c-88a8-f4fd40d75dad"), null, new DateTime(2024, 11, 24, 23, 6, 42, 120, DateTimeKind.Utc).AddTicks(4107), null, null, "Customer 1", null, "aWhkUoP7OEybXwQGwpjycbWp4HTnz2KfqdYBnMtTFkzm582l", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 120, DateTimeKind.Utc).AddTicks(4111), "Customer1" },
                    { new Guid("43c46811-0b29-4c91-8eff-a67369a5ca8d"), null, new DateTime(2024, 11, 24, 23, 6, 42, 123, DateTimeKind.Utc).AddTicks(4151), null, null, "Customer 2", null, "wsfS5lgqFHdRKDeA87Z0QY/kKBHIcpQ/gggEC9riFovVbMig", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 123, DateTimeKind.Utc).AddTicks(4152), "Customer2" },
                    { new Guid("4af09939-9312-4521-8780-8d49f1e9ccd4"), null, new DateTime(2024, 11, 24, 23, 6, 42, 157, DateTimeKind.Utc).AddTicks(603), null, null, "Customer 13", null, "0jhZ76kEGUOjTjBXRDRT8YbXzuwY9924ENBKzn8dRdUhzLzt", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 157, DateTimeKind.Utc).AddTicks(604), "Customer13" },
                    { new Guid("503ddd69-0f19-4b48-92de-c8e15a0e9e1d"), null, new DateTime(2024, 11, 24, 23, 6, 42, 144, DateTimeKind.Utc).AddTicks(9694), null, null, "Customer 9", null, "DvlNh82CPRcw2d4Xp/qmN3uz1h++GWiBr+AEzSi2zO9NEMj2", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 144, DateTimeKind.Utc).AddTicks(9702), "Customer9" },
                    { new Guid("5a74f9e4-3358-45db-958f-37b58b3255e3"), null, new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2402), null, null, "Admin 1", null, "eoYOJ66vJAgFTXisR4XubpyJN30P5k9NuFVgBeoWHYXizuxi", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2402), "Admin1" },
                    { new Guid("7777a24a-4b2e-4b7e-b14c-2c066dab0b53"), null, new DateTime(2024, 11, 24, 23, 6, 42, 135, DateTimeKind.Utc).AddTicks(7184), null, null, "Customer 6", null, "jHg+s47EpYXNGlGuuomlZlMykMoewG6QoK2EG5/jdjASUkYl", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 135, DateTimeKind.Utc).AddTicks(7184), "Customer6" },
                    { new Guid("898d9a28-7f48-4bc6-8ead-2890f7993d42"), null, new DateTime(2024, 11, 24, 23, 6, 42, 163, DateTimeKind.Utc).AddTicks(1769), null, null, "Customer 15", null, "7PZnNsUcasVc+8svy+jtreeq6dP31n387EBr4JJ1VOx8GDhk", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 163, DateTimeKind.Utc).AddTicks(1769), "Customer15" },
                    { new Guid("99cd22b8-fa62-41f5-9a6f-05a1d60d431c"), null, new DateTime(2024, 11, 24, 23, 6, 42, 117, DateTimeKind.Utc).AddTicks(2974), null, null, "Admin 2", null, "Bcvpw/jUZthtQbo8X9uQl09llI/m/lZCPnckZ9N5D0cfkrNt", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 23, 6, 42, 117, DateTimeKind.Utc).AddTicks(2974), "Admin2" },
                    { new Guid("a88fc8d0-7f69-4c04-815d-0562d552dc64"), null, new DateTime(2024, 11, 24, 23, 6, 42, 141, DateTimeKind.Utc).AddTicks(8238), null, null, "Customer 8", null, "uG5Tx8PGtpnLCh8j+wvNKGMF8brEXapOm446TLlSkx/WP5L8", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 141, DateTimeKind.Utc).AddTicks(8239), "Customer8" },
                    { new Guid("c844df94-fca8-430e-a778-bd30777b671e"), null, new DateTime(2024, 11, 24, 23, 6, 42, 160, DateTimeKind.Utc).AddTicks(1434), null, null, "Customer 14", null, "UcRrM2NRXNrS7pfQRrQi5UpyTgmNIFP9LQ7+Y/gdnviY42qb", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 160, DateTimeKind.Utc).AddTicks(1435), "Customer14" },
                    { new Guid("e9ea8474-ca77-487d-9f56-2f9b63cd8db9"), null, new DateTime(2024, 11, 24, 23, 6, 42, 126, DateTimeKind.Utc).AddTicks(4224), null, null, "Customer 3", null, "AlAsDCTnNTbhk9OnSNNnusM0DMJeIz3suyOsSL+8yjp13p4b", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 126, DateTimeKind.Utc).AddTicks(4224), "Customer3" },
                    { new Guid("ecd1be51-2688-4acb-8794-6e73d15533a9"), null, new DateTime(2024, 11, 24, 23, 6, 42, 132, DateTimeKind.Utc).AddTicks(7311), null, null, "Customer 5", null, "tkyEahq4NeRJ4hzc50Zh+m3nYf2HfDkhRPwMK7a4+1p9ER8v", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 132, DateTimeKind.Utc).AddTicks(7326), "Customer5" },
                    { new Guid("f1ba2a9e-d38d-4fc5-b9f8-2cf6e321ef3f"), null, new DateTime(2024, 11, 24, 23, 6, 42, 138, DateTimeKind.Utc).AddTicks(7517), null, null, "Customer 7", null, "Jz+LqjeOaxFvWLAnd51ysI74RM/fiQbl43x44LkTu8C4jqSL", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 138, DateTimeKind.Utc).AddTicks(7518), "Customer7" },
                    { new Guid("fc384321-75b7-497c-a5d5-7a66052233f3"), null, new DateTime(2024, 11, 24, 23, 6, 42, 151, DateTimeKind.Utc).AddTicks(359), null, null, "Customer 11", null, "BIK5jxW3614ojWFsn5VANXCu9ZFPjjy9kbYnk6No2kcR+lJa", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 151, DateTimeKind.Utc).AddTicks(360), "Customer11" },
                    { new Guid("fde6ab79-7c76-449e-ae4d-032acaea96ec"), null, new DateTime(2024, 11, 24, 23, 6, 42, 154, DateTimeKind.Utc).AddTicks(464), null, null, "Customer 12", null, "GI8z2RW0zclf5zWTf1pbcJg4yMMMrRL4YlEVjILewHtx5Kjl", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 23, 6, 42, 154, DateTimeKind.Utc).AddTicks(464), "Customer12" }
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
