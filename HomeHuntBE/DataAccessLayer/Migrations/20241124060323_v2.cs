using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("259b3c67-a831-45e9-b60b-138d7a82df22"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("42582052-3372-4af3-b92e-08e4b693624b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("480f467e-584a-4db8-b09c-2d048e27bdad"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("52c00960-f9b3-400a-bdf8-c9ab7f3cb593"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5980cd49-2258-4f11-8f15-14cd6d5ee63e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5fa95a35-c5c6-4f30-ae3a-3352dae893f5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("66b1903d-7530-46aa-8238-fc977826b0d7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7273e674-9db1-4149-b85a-47b41b3099ac"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7c932580-58d3-4a0e-8243-082adc079e4c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("86d2c664-e2f9-408a-94e9-3210cc46b89c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8b4f2efc-6cca-4552-9495-e1acc956ebf3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("91d993ce-7c07-4647-8c7f-be94ebf338bc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b4fe710e-a9d8-40bc-a9c3-47e4287f29bc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("baadd74a-09f6-4023-b85c-18867760df39"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c140c022-70f5-4f42-bf13-a0cf1af88417"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f326a3b8-f525-42ed-b58a-fc13ad62ed3d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fbddcf19-f506-46be-80ef-1077d2ee2ddb"));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1765), new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1781), new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedDate", "Dob", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("040ffc26-33a8-4ab4-b556-dc946ebe5728"), null, new DateTime(2024, 11, 24, 13, 3, 21, 803, DateTimeKind.Utc).AddTicks(5218), null, null, "Customer 5", null, "1ltAVx/JkrMqA94ifbi+1v+5vr9JxzADks8e7ywE2RTajhZr", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 803, DateTimeKind.Utc).AddTicks(5222), "Customer5" },
                    { new Guid("09197de0-e732-4cd6-8c58-6516d7c02d4e"), null, new DateTime(2024, 11, 24, 13, 3, 21, 789, DateTimeKind.Utc).AddTicks(1635), null, null, "Admin 2", null, "D1CGN7AYw/a/FnPKyrJjasDg00IPiN3lQQANdEWZsr0x3kRb", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 13, 3, 21, 789, DateTimeKind.Utc).AddTicks(1635), "Admin2" },
                    { new Guid("161d2302-96dc-4a6a-900e-e252ff3ddff5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 797, DateTimeKind.Utc).AddTicks(7151), null, null, "Customer 3", null, "jmHghkkUIJHe+eY8mhFACjmx22Nzr5VYXgLW+WgCWr9ygA2O", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 797, DateTimeKind.Utc).AddTicks(7153), "Customer3" },
                    { new Guid("35b94f91-9c5a-4f59-bcb9-f8a5901447a1"), null, new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1915), null, null, "Admin 1", null, "m4SBywVqpxsPfkrBAMcy/6J7pdV5G7l95v47jfT8LbBRMPr9", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1915), "Admin1" },
                    { new Guid("488f3bc8-8a9b-4c08-a3e8-4c4c7e6be936"), null, new DateTime(2024, 11, 24, 13, 3, 21, 826, DateTimeKind.Utc).AddTicks(5493), null, null, "Customer 13", null, "lTZjoV/ISqhSdBUYq3WmMp/EGZSyrBqI7xpoBcmPcgEDy00y", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 826, DateTimeKind.Utc).AddTicks(5493), "Customer13" },
                    { new Guid("79862b1b-05f0-456b-996d-0594afe6997f"), null, new DateTime(2024, 11, 24, 13, 3, 21, 809, DateTimeKind.Utc).AddTicks(3080), null, null, "Customer 7", null, "06HUx3l94Ou2G5gEU0wyRD08lRtBbK8dwtDo1XsPb1fzTyYI", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 809, DateTimeKind.Utc).AddTicks(3080), "Customer7" },
                    { new Guid("7c9244d2-83e6-42e6-8bc3-57d8d8ea75c9"), null, new DateTime(2024, 11, 24, 13, 3, 21, 817, DateTimeKind.Utc).AddTicks(8823), null, null, "Customer 10", null, "4TtmXSMM0rhBM7kUoH/P5yyabD3sYoOyxynQZ7S/zQPeFQ1q", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 817, DateTimeKind.Utc).AddTicks(8824), "Customer10" },
                    { new Guid("8307da63-c686-4c23-b6b1-1d5d8c9826ee"), null, new DateTime(2024, 11, 24, 13, 3, 21, 820, DateTimeKind.Utc).AddTicks(6925), null, null, "Customer 11", null, "BSnviwfiEGZYHsJIdpGPimRG9DkPcAuHa9R+PkRS+cQ5UfcV", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 820, DateTimeKind.Utc).AddTicks(6926), "Customer11" },
                    { new Guid("86ae9865-3e9f-431d-a1a3-97280844f1ff"), null, new DateTime(2024, 11, 24, 13, 3, 21, 800, DateTimeKind.Utc).AddTicks(5882), null, null, "Customer 4", null, "BiZvHxa6HSDsJeP4u+8VuA8clkHG5G+4YEmqkcpzev/ZYUs8", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 800, DateTimeKind.Utc).AddTicks(5882), "Customer4" },
                    { new Guid("88382944-5519-4c08-9a8c-ddf9a83ff84c"), null, new DateTime(2024, 11, 24, 13, 3, 21, 823, DateTimeKind.Utc).AddTicks(7016), null, null, "Customer 12", null, "+jAvr4xdGM0VM0bgAhCAOh7QomUZScwd05LuGfF5om7HWU7e", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 823, DateTimeKind.Utc).AddTicks(7017), "Customer12" },
                    { new Guid("88d04c09-6108-45e1-8f00-3c3bafd67daa"), null, new DateTime(2024, 11, 24, 13, 3, 21, 806, DateTimeKind.Utc).AddTicks(3727), null, null, "Customer 6", null, "Sd1Nh6fHq2OTCryH68djL7VucWEc5KOu6wZjS5yxiauCDC8V", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 806, DateTimeKind.Utc).AddTicks(3727), "Customer6" },
                    { new Guid("a4bbafd8-7e20-4fb8-b1c9-d8e700b334e3"), null, new DateTime(2024, 11, 24, 13, 3, 21, 792, DateTimeKind.Utc).AddTicks(677), null, null, "Customer 1", null, "dyyK+Su14P1K2lCKEXKjZCB5E+pgxfvDef7t7bA/qJQUbS7J", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 792, DateTimeKind.Utc).AddTicks(682), "Customer1" },
                    { new Guid("c1d076d5-b314-412f-a66d-1db332ee62e3"), null, new DateTime(2024, 11, 24, 13, 3, 21, 812, DateTimeKind.Utc).AddTicks(1151), null, null, "Customer 8", null, "P4EiRrmfe5hQTy9odPM18RPiqQ459+z6bylr7ifVHWGeScgx", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 812, DateTimeKind.Utc).AddTicks(1152), "Customer8" },
                    { new Guid("cc704cca-d516-42ae-8a39-69ae714aeb8a"), null, new DateTime(2024, 11, 24, 13, 3, 21, 814, DateTimeKind.Utc).AddTicks(9849), null, null, "Customer 9", null, "9+I7PPimM6Dv8F0RN8bDFDopbu59aQdDx4pRLeTwmtL030JX", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 814, DateTimeKind.Utc).AddTicks(9849), "Customer9" },
                    { new Guid("cd75d1d1-379d-4c82-b24e-9953fc81f357"), null, new DateTime(2024, 11, 24, 13, 3, 21, 832, DateTimeKind.Utc).AddTicks(3223), null, null, "Customer 15", null, "jF/iGRVbkbyipcmYj2uB1WxAokg1ytU+XQfuLcVF6u8ZqHUw", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 832, DateTimeKind.Utc).AddTicks(3224), "Customer15" },
                    { new Guid("e864b26a-d14d-4fdb-8fc3-b0adc132b38d"), null, new DateTime(2024, 11, 24, 13, 3, 21, 794, DateTimeKind.Utc).AddTicks(8697), null, null, "Customer 2", null, "XeT+xB7OQnvZGXt9zvjBsVXbR4951HaaiIUVXlkImF/PYuie", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 794, DateTimeKind.Utc).AddTicks(8698), "Customer2" },
                    { new Guid("f7e84332-7ae5-466d-825f-e4fb7a2f412b"), null, new DateTime(2024, 11, 24, 13, 3, 21, 829, DateTimeKind.Utc).AddTicks(4113), null, null, "Customer 14", null, "CDb7RhGWX08nT4bV5bgk4VWXoDN0wTJrba4KMmMIoJp4tCyE", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 13, 3, 21, 829, DateTimeKind.Utc).AddTicks(4114), "Customer14" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("040ffc26-33a8-4ab4-b556-dc946ebe5728"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("09197de0-e732-4cd6-8c58-6516d7c02d4e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("161d2302-96dc-4a6a-900e-e252ff3ddff5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("35b94f91-9c5a-4f59-bcb9-f8a5901447a1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("488f3bc8-8a9b-4c08-a3e8-4c4c7e6be936"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79862b1b-05f0-456b-996d-0594afe6997f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7c9244d2-83e6-42e6-8bc3-57d8d8ea75c9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8307da63-c686-4c23-b6b1-1d5d8c9826ee"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("86ae9865-3e9f-431d-a1a3-97280844f1ff"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("88382944-5519-4c08-9a8c-ddf9a83ff84c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("88d04c09-6108-45e1-8f00-3c3bafd67daa"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4bbafd8-7e20-4fb8-b1c9-d8e700b334e3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c1d076d5-b314-412f-a66d-1db332ee62e3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cc704cca-d516-42ae-8a39-69ae714aeb8a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cd75d1d1-379d-4c82-b24e-9953fc81f357"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e864b26a-d14d-4fdb-8fc3-b0adc132b38d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f7e84332-7ae5-466d-825f-e4fb7a2f412b"));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5818), new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 11, 12, 1, 45, 18, 951, DateTimeKind.Utc).AddTicks(5832) });

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
        }
    }
}
