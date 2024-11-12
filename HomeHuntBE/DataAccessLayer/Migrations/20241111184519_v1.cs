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
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("transaction_id_primary", x => x.Id);
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
                    { new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5818), "Admin", null, new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5829) },
                    { new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5832), "Customer", null, new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5832) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedDate", "Dob", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("259b3c67-a831-45e9-b60b-138d7a82df22"), null, new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5966), null, null, "Admin 1", null, "YrsnmFXnqf38PVKLlpeks1QlqFxFgCirL6D/g50pmLex+iy8", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5966), "Admin1" },
                    { new Guid("42582052-3372-4af3-b92e-08e4b693624b"), null, new DateTime(2024, 11, 12, 1, 45, 18, 962, DateTimeKind.Utc).AddTicks(9945), null, null, "Customer 3", null, "ITFKJ+Y7UIFacYkXkXXxYXFZ1x8Ji0CMMz/7alleelwJ1ZiG", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 962, DateTimeKind.Utc).AddTicks(9946), "Customer3" },
                    { new Guid("480f467e-584a-4db8-b09c-2d048e27bdad"), null, new DateTime(2024, 11, 12, 1, 45, 18, 968, DateTimeKind.Utc).AddTicks(6626), null, null, "Customer 5", null, "CrNO3VJd5XKVcYsR6Aywf2exFuq8ci60eJrQnfKL53msguGh", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 968, DateTimeKind.Utc).AddTicks(6626), "Customer5" },
                    { new Guid("52c00960-f9b3-400a-bdf8-c9ab7f3cb593"), null, new DateTime(2024, 11, 12, 1, 45, 18, 996, DateTimeKind.Utc).AddTicks(1229), null, null, "Customer 14", null, "C23TAbso12hxTK0LzPYc8mRw+3wBBoljNRZkettaZPLru+th", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 996, DateTimeKind.Utc).AddTicks(1237), "Customer14" },
                    { new Guid("5980cd49-2258-4f11-8f15-14cd6d5ee63e"), null, new DateTime(2024, 11, 12, 1, 45, 18, 954, DateTimeKind.Utc).AddTicks(5459), null, null, "Admin 2", null, "iO5E3YcWy4cTlpvgCwgEsnXmptoR876Q6ielWoX2TY1TliQA", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 12, 1, 45, 18, 954, DateTimeKind.Utc).AddTicks(5460), "Admin2" },
                    { new Guid("5fa95a35-c5c6-4f30-ae3a-3352dae893f5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 990, DateTimeKind.Utc).AddTicks(1269), null, null, "Customer 12", null, "31L68eBWqYDaC7KwkELSo9iif0IbY79xM7zN4T+D/tL0X+QV", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 990, DateTimeKind.Utc).AddTicks(1272), "Customer12" },
                    { new Guid("66b1903d-7530-46aa-8238-fc977826b0d7"), null, new DateTime(2024, 11, 12, 1, 45, 18, 972, DateTimeKind.Utc).AddTicks(7573), null, null, "Customer 6", null, "pXnUH3RIpnIDtpuZgCN2Q420Y3zWsaqVRxM8gVqrOFznIDPe", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 972, DateTimeKind.Utc).AddTicks(7581), "Customer6" },
                    { new Guid("7273e674-9db1-4149-b85a-47b41b3099ac"), null, new DateTime(2024, 11, 12, 1, 45, 18, 998, DateTimeKind.Utc).AddTicks(8949), null, null, "Customer 15", null, "DEBJbEuyZXb1DMoXb0JTXUVWv9p/tSEbgIZB8D+lNNvkU8Y+", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 998, DateTimeKind.Utc).AddTicks(8950), "Customer15" },
                    { new Guid("7c932580-58d3-4a0e-8243-082adc079e4c"), null, new DateTime(2024, 11, 12, 1, 45, 18, 993, DateTimeKind.Utc).AddTicks(2394), null, null, "Customer 13", null, "yh4VgjPYU/XFwf7uQuWRjBxY7Z0eetRxQveveQv6w0cDN6JI", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 993, DateTimeKind.Utc).AddTicks(2395), "Customer13" },
                    { new Guid("86d2c664-e2f9-408a-94e9-3210cc46b89c"), null, new DateTime(2024, 11, 12, 1, 45, 18, 986, DateTimeKind.Utc).AddTicks(9532), null, null, "Customer 11", null, "DGVJ9I8UqB4ks3Fvjw9sfM/c5Nh7bSD592UFfTFAD9uT9BYs", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 986, DateTimeKind.Utc).AddTicks(9532), "Customer11" },
                    { new Guid("8b4f2efc-6cca-4552-9495-e1acc956ebf3"), null, new DateTime(2024, 11, 12, 1, 45, 18, 965, DateTimeKind.Utc).AddTicks(8260), null, null, "Customer 4", null, "ZuCKPNcqLkR9ZsWIa9/5xYvtrvYt8ycxB51+4dGS4LKwOt2g", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 965, DateTimeKind.Utc).AddTicks(8260), "Customer4" },
                    { new Guid("91d993ce-7c07-4647-8c7f-be94ebf338bc"), null, new DateTime(2024, 11, 12, 1, 45, 18, 960, DateTimeKind.Utc).AddTicks(2091), null, null, "Customer 2", null, "Rv6KnnXqe+Uu+c3OszrAF0I0y6TxOSZybTvY9lMToD335W32", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 960, DateTimeKind.Utc).AddTicks(2091), "Customer2" },
                    { new Guid("b4fe710e-a9d8-40bc-a9c3-47e4287f29bc"), null, new DateTime(2024, 11, 12, 1, 45, 18, 957, DateTimeKind.Utc).AddTicks(3118), null, null, "Customer 1", null, "KDoU+dR049bc1p6ClpxHJQBGB1yYEY7jTmwEGHU0nPBGW9J4", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 957, DateTimeKind.Utc).AddTicks(3120), "Customer1" },
                    { new Guid("baadd74a-09f6-4023-b85c-18867760df39"), null, new DateTime(2024, 11, 12, 1, 45, 18, 984, DateTimeKind.Utc).AddTicks(1857), null, null, "Customer 10", null, "h7kZ6EDoct7YuQoQizVYlbFKMxkdfAnRVPfSnEk5lEmJrhKn", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 984, DateTimeKind.Utc).AddTicks(1857), "Customer10" },
                    { new Guid("c140c022-70f5-4f42-bf13-a0cf1af88417"), null, new DateTime(2024, 11, 12, 1, 45, 18, 981, DateTimeKind.Utc).AddTicks(4061), null, null, "Customer 9", null, "11Io8BY+uQTkbGRYRVfNlJig+fHEJBb6SBO4vPAqXDDz5KUj", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 981, DateTimeKind.Utc).AddTicks(4063), "Customer9" },
                    { new Guid("f326a3b8-f525-42ed-b58a-fc13ad62ed3d"), null, new DateTime(2024, 11, 12, 1, 45, 18, 978, DateTimeKind.Utc).AddTicks(3869), null, null, "Customer 8", null, "bRNYnDTlgxF+fn7rYCL0y8SjVXgF6JXk+wxu7RFmOZnWTLVP", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 978, DateTimeKind.Utc).AddTicks(3869), "Customer8" },
                    { new Guid("fbddcf19-f506-46be-80ef-1077d2ee2ddb"), null, new DateTime(2024, 11, 12, 1, 45, 18, 975, DateTimeKind.Utc).AddTicks(6142), null, null, "Customer 7", null, "Bu+vhbaXlVJECpQ/qDXt1o21F6q6ghMRIMpcBJZkYgyM8FPh", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 12, 1, 45, 18, 975, DateTimeKind.Utc).AddTicks(6142), "Customer7" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
                column: "UserId");

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
                name: "Post");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
