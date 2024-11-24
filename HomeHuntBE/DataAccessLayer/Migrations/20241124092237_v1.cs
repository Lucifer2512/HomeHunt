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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
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
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
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
                    { new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(1881), "Admin", null, new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(1890) },
                    { new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(1894), "Customer", null, new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(1894) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedDate", "Dob", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("13ebfc3b-a208-48b2-bf17-eafbb47c8abf"), null, new DateTime(2024, 11, 24, 16, 22, 36, 690, DateTimeKind.Utc).AddTicks(944), null, null, "Customer 2", null, "SGVpB8uWfV54Y+iMaHIoZqfdiBFPB3C1lcYNoaYNqCDtdgyH", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 690, DateTimeKind.Utc).AddTicks(945), "Customer2" },
                    { new Guid("25094731-0dd2-4e34-b0b1-cc4f12d1218e"), null, new DateTime(2024, 11, 24, 16, 22, 36, 684, DateTimeKind.Utc).AddTicks(1337), null, null, "Admin 2", null, "VaTRJ+GiXRygV180D67YAqqRt3ouHnObXW/LJzBeZSYGtVuW", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 16, 22, 36, 684, DateTimeKind.Utc).AddTicks(1337), "Admin2" },
                    { new Guid("285c2b83-1372-4f7e-a4f1-9ba5d285f745"), null, new DateTime(2024, 11, 24, 16, 22, 36, 723, DateTimeKind.Utc).AddTicks(3679), null, null, "Customer 13", null, "RWF0WXYf2rT1TlVB+38GFBxSPZ7OKckbPdfSD3OkkDt2y5BH", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 723, DateTimeKind.Utc).AddTicks(3679), "Customer13" },
                    { new Guid("2a226b52-85e3-4980-b351-44c63c041a23"), null, new DateTime(2024, 11, 24, 16, 22, 36, 717, DateTimeKind.Utc).AddTicks(3946), null, null, "Customer 11", null, "hJVacPPeEVlo2YZ8wd6jCk+ljjoY5fux1IaHbi0bCDFegfAC", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 717, DateTimeKind.Utc).AddTicks(3946), "Customer11" },
                    { new Guid("343f69d9-58df-4138-9eed-e1c57d57c1c9"), null, new DateTime(2024, 11, 24, 16, 22, 36, 699, DateTimeKind.Utc).AddTicks(2108), null, null, "Customer 5", null, "KZK77jGphy9IwrfPhlqtS4jEyjCv89nm0af8ss+BiKAGvJel", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 699, DateTimeKind.Utc).AddTicks(2108), "Customer5" },
                    { new Guid("487c1f41-09ef-4709-a973-baf9791b2496"), null, new DateTime(2024, 11, 24, 16, 22, 36, 705, DateTimeKind.Utc).AddTicks(2148), null, null, "Customer 7", null, "WvFFAK7zwWntkgtu+s7VuCTnut0XSBHSX1mYwiq6utGWvtwc", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 705, DateTimeKind.Utc).AddTicks(2152), "Customer7" },
                    { new Guid("4942612a-10d2-4256-b7c1-7cfc9fcc8606"), null, new DateTime(2024, 11, 24, 16, 22, 36, 696, DateTimeKind.Utc).AddTicks(1299), null, null, "Customer 4", null, "toeujrfk7dSbyCAYYzZEcCTtn6enKuv72dfFMjoMo/2ADrXk", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 696, DateTimeKind.Utc).AddTicks(1300), "Customer4" },
                    { new Guid("6e8855fe-c1ea-42ff-9773-f46d05d02f8c"), null, new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(2023), null, null, "Admin 1", null, "ZzTC4pDV4YTuklbaVpd6P0eu6U1hEiR2V3aL09N1F3SsI/CZ", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(2024), "Admin1" },
                    { new Guid("6ea8b671-c546-48c4-8f33-b822d4ea90a1"), null, new DateTime(2024, 11, 24, 16, 22, 36, 729, DateTimeKind.Utc).AddTicks(2905), null, null, "Customer 15", null, "UZSosDsrZZNYjjhq4rPn7Qmx81boFcnDOQMYQ1l7x4wbpEWT", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 729, DateTimeKind.Utc).AddTicks(2905), "Customer15" },
                    { new Guid("8cb777ea-ed9b-4336-9feb-48deb536dfa1"), null, new DateTime(2024, 11, 24, 16, 22, 36, 711, DateTimeKind.Utc).AddTicks(3957), null, null, "Customer 9", null, "/d+P3btvdjl4mNEjKwVQOy87tK+cTYG/hDLArg5zz8uHYhsz", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 711, DateTimeKind.Utc).AddTicks(3967), "Customer9" },
                    { new Guid("a4de10b4-0586-46c9-8b21-fcd06ac6aff3"), null, new DateTime(2024, 11, 24, 16, 22, 36, 726, DateTimeKind.Utc).AddTicks(3440), null, null, "Customer 14", null, "Ythpq0XRAV8+4XWDJUkg3O20ERUZYj1eFoaGfcxfOv4JMVdS", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 726, DateTimeKind.Utc).AddTicks(3440), "Customer14" },
                    { new Guid("c2b8dfee-321b-4bf6-8a45-ccff991d3315"), null, new DateTime(2024, 11, 24, 16, 22, 36, 720, DateTimeKind.Utc).AddTicks(3513), null, null, "Customer 12", null, "ZGp8PfSLQjPB9buToepyzf5rw1xzHDwq2so+o6O2C+GNlMIR", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 720, DateTimeKind.Utc).AddTicks(3517), "Customer12" },
                    { new Guid("c792280c-0307-4dcd-ad2b-5c2e8bbfc99f"), null, new DateTime(2024, 11, 24, 16, 22, 36, 702, DateTimeKind.Utc).AddTicks(2329), null, null, "Customer 6", null, "ebujxxFQaF9A0ldE3j9EGoZDHw4hZiEuWJr+6zsfIYSOOjkA", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 702, DateTimeKind.Utc).AddTicks(2333), "Customer6" },
                    { new Guid("ca24526e-bda1-43db-9ad7-49a03672a13d"), null, new DateTime(2024, 11, 24, 16, 22, 36, 714, DateTimeKind.Utc).AddTicks(4056), null, null, "Customer 10", null, "4q5eUlnLZHNtV5mpQb3aCpCnXSFWq4XOwOV+4jy1kQbZoxOV", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 714, DateTimeKind.Utc).AddTicks(4057), "Customer10" },
                    { new Guid("d86248fb-ea9b-4fcd-b662-194148cd95c9"), null, new DateTime(2024, 11, 24, 16, 22, 36, 687, DateTimeKind.Utc).AddTicks(1252), null, null, "Customer 1", null, "ew/WcbTC9NDulDl9CNtvkP29WhOtnMy9Mlx4IvpmcHTpJcFQ", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 687, DateTimeKind.Utc).AddTicks(1252), "Customer1" },
                    { new Guid("e2a039fe-a42f-47d2-a449-f95972ff9630"), null, new DateTime(2024, 11, 24, 16, 22, 36, 693, DateTimeKind.Utc).AddTicks(1365), null, null, "Customer 3", null, "U4CbFXvLCzuyZiPynlPt5sGjXg13W3241+Qt+iGERLkN5ZMI", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 693, DateTimeKind.Utc).AddTicks(1366), "Customer3" },
                    { new Guid("ead045a4-784d-4355-930c-88f97a4c1f3c"), null, new DateTime(2024, 11, 24, 16, 22, 36, 708, DateTimeKind.Utc).AddTicks(2899), null, null, "Customer 8", null, "dAmbdlCjZ53JJMc8o5cSwu0cagVixX5MKRRzTcCfNqsLmfKg", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 22, 36, 708, DateTimeKind.Utc).AddTicks(2900), "Customer8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PostId",
                table: "Transaction",
                column: "PostId",
                unique: true);

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
