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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Deposit = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
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

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, "Admin", null, null },
                    { new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, "Customer", null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedDate", "Dob", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("02225135-f486-4755-ae8c-c44a7562bb4c"), null, null, null, null, "Customer 8", null, "aI/pLjTOpKNuXbOfbTEoD7hFwCaN0KQC30rWyKUl/SwQsPU0", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer8" },
                    { new Guid("1d06ca65-ad44-4bff-b7a7-1a4039763880"), null, null, null, null, "Customer 4", null, "iqyDjmKTPEyvtkFj5DVhoByYebFYWHy7HnJISjfiORG0vpkW", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer4" },
                    { new Guid("2ead1812-5078-4262-8f22-9b00b0a5b94f"), null, null, null, null, "Customer 7", null, "3rLfzTzeohKaBDPKOXEPy1qRWGQPcLufWtjaMBZYBe+8IoMQ", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer7" },
                    { new Guid("65d9946c-9479-47d8-a9f3-ad3c9f8de268"), null, null, null, null, "Customer 14", null, "Fm9aQSJbTFAnTocArxCShj0ArSS+GldTSzF/bIoBtgv6u6Os", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer14" },
                    { new Guid("6d4efbf5-57e2-4521-b0cd-02b6423391de"), null, null, null, null, "Customer 13", null, "TqKK78dCYQgD4I2np48J+CoCqvn00FKWHawLuz3Y+6M9bVNJ", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer13" },
                    { new Guid("8096e6cd-b480-4003-bbf2-cbf72a273012"), null, null, null, null, "Customer 10", null, "RVBpk+binuzvGy39fcEDyRB9D6CBlnoQYzE6KMG3BoYcw+yp", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer10" },
                    { new Guid("8d0512d9-4934-4a59-afc9-7ca829610867"), null, null, null, null, "Customer 9", null, "Km/Zr9HQnHPl1AU2K6Itlea0GZ2eMp0Qz/Nr9J3yyBfZtZKD", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer9" },
                    { new Guid("9496aab7-d66c-4001-9cf9-d3c65713970e"), null, null, null, null, "Customer 3", null, "y+cSla+oVnHKEcihX9uUfva6cCrnVTndoWdRsuI0zyKEQJWO", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer3" },
                    { new Guid("98688ba0-3003-4aa5-8bd2-93ced308e027"), null, null, null, null, "Admin 2", null, "Wd/usMCgquZ83NokCzRyGLOd0UB7qb9El9Q69/T4syeI0qVU", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, null, "Admin2" },
                    { new Guid("9ca56bed-13ca-4067-8a72-551bcd35318c"), null, null, null, null, "Admin 1", null, "5rH4V4vMfua+KRkWe+JH9zS7FuO/2XBj/5LnSPQjaUh/gvXW", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, null, "Admin1" },
                    { new Guid("a35a1a07-ec1e-4070-ab82-001b52a568d9"), null, null, null, null, "Customer 2", null, "HYlJFGqPzpjuK2jJsMZTVEwoufNNBUQmGDNQ8YAz1E8MFHkj", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer2" },
                    { new Guid("a89ba03b-fdb1-4bca-a13a-f6d3b3e42171"), null, null, null, null, "Customer 1", null, "HUmMGn5qNqCQkUxU+szcYqpgJTmJ898ZlLVGLtixgMcf79qb", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer1" },
                    { new Guid("b7074ced-a177-49f5-81ee-a57f96b2091d"), null, null, null, null, "Customer 12", null, "ng16blBP82WpSucSaOqEv2mg5ruHJox/m/RhWzQjvwoOW+1f", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer12" },
                    { new Guid("cf8f0a56-d072-4fe7-af8a-56953e4df553"), null, null, null, null, "Customer 5", null, "QCAW06OGrNuaTsueJu43rGw2nLBWUdOnCUGyi5c3Bv9I5jnl", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer5" },
                    { new Guid("d28029b2-f642-49f0-802b-40cc1d894fd5"), null, null, null, null, "Customer 15", null, "0jSJy3Ll3dp1Y4ienuDQLQwRVklaVv5E29pdzfSqgivTn8l5", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer15" },
                    { new Guid("dd9fb8a7-4153-4fa6-b6b6-ab6c9df0ca77"), null, null, null, null, "Customer 11", null, "cax3dyvzW9B7jWQSKJ4q+ulPK4DeJLJrB9e0PBWZKGf6XH8r", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer11" },
                    { new Guid("df936c1d-4ebf-435a-8f80-41110f31a071"), null, null, null, null, "Customer 6", null, "ERA/vOyWxAmpBJMAfQ+ACSSZ7jFn9ZDpTM/c0FGLYni7Ng6p", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, null, "Customer6" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
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
                name: "Post");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
