using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d41ed62-f11c-4359-a274-0820db174d3a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("164051b5-05a6-4537-8422-2f95f28b0dee"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("16b67611-f69b-437e-87d2-c43726444e54"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2046f97c-964c-40e3-9079-2519a1c8651a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("39fdab54-434b-458d-a906-2664afa782de"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4312b50d-a8f6-4af1-963e-4554046e7f7c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("436f062d-fcba-4010-b045-6d57a4c244e9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("590b72e7-152d-4b73-9c53-364a831bfc2b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("59729a30-4b6d-4d75-abab-4d657e76dc25"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6722eb35-3f74-4a70-9f2e-a0be5b80debf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6fd9d888-fae7-446a-a969-f106711d166a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("78421daf-d7a0-490a-a9e1-5a65b044ed83"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("83495983-2957-45af-adcb-7e29cbbb051e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8dcb57f1-e75d-4fd3-b9ab-88e61f6cdb89"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8ea53a34-702f-4112-b70a-0d836d4b16e5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("915905ba-f8a2-47e8-a619-5c426379e81f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b855f2cc-c03c-4b08-8b8e-b07440c681a6"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Transaction",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Post",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Deposit",
                table: "Post",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 24, 17, 57, 40, 403, DateTimeKind.Utc).AddTicks(8151), new DateTime(2024, 11, 24, 17, 57, 40, 403, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 24, 17, 57, 40, 403, DateTimeKind.Utc).AddTicks(8165), new DateTime(2024, 11, 24, 17, 57, 40, 403, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedDate", "Dob", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("0250cf6e-5d7c-4c54-ad02-022a2da5dab6"), null, new DateTime(2024, 11, 24, 17, 57, 40, 418, DateTimeKind.Utc).AddTicks(5379), null, null, "Customer 4", null, "bDty53oH0u6fxpd9ibcYbdJhNkspNmudmurIqgyU4p+lx6VP", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 418, DateTimeKind.Utc).AddTicks(5380), "Customer4" },
                    { new Guid("17833b13-2d9e-4891-b66e-a6769a6255ea"), null, new DateTime(2024, 11, 24, 17, 57, 40, 435, DateTimeKind.Utc).AddTicks(1671), null, null, "Customer 10", null, "T2b0ACCL7zDHVk9CrdhTlOXvQXspFEJ/u9qUVaUdmyLGXbu7", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 435, DateTimeKind.Utc).AddTicks(1671), "Customer10" },
                    { new Guid("17c12695-d177-4fab-9351-c6061c5575bb"), null, new DateTime(2024, 11, 24, 17, 57, 40, 437, DateTimeKind.Utc).AddTicks(9176), null, null, "Customer 11", null, "k47XA/lSnqLXYS+7r6QUqjDYngu7h13xQV0eV25dYaZV1Of9", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 437, DateTimeKind.Utc).AddTicks(9176), "Customer11" },
                    { new Guid("1b50e379-ab7c-481b-973f-a5ce11c0847e"), null, new DateTime(2024, 11, 24, 17, 57, 40, 412, DateTimeKind.Utc).AddTicks(6241), null, null, "Customer 2", null, "3wlrI7Gcrv+gs6dV0AKg9Vyv6zCS90ETApMZdCU7U3R9O8eA", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 412, DateTimeKind.Utc).AddTicks(6241), "Customer2" },
                    { new Guid("1c1999ca-01b7-4936-bda9-ce1bf5671dd9"), null, new DateTime(2024, 11, 24, 17, 57, 40, 406, DateTimeKind.Utc).AddTicks(7811), null, null, "Admin 2", null, "/f1FvU3Ajhr8q3T8+ZWQbbOwKQwW6KKcE1QI3dwRLWZTlPBo", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 17, 57, 40, 406, DateTimeKind.Utc).AddTicks(7812), "Admin2" },
                    { new Guid("1dd00cbb-9515-4a31-8efa-223e78a8919d"), null, new DateTime(2024, 11, 24, 17, 57, 40, 424, DateTimeKind.Utc).AddTicks(1285), null, null, "Customer 6", null, "OqggDAUyyiMb7Nn1TOxQCHPB+uMBrvx3IlEu5qCdeekF08pJ", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 424, DateTimeKind.Utc).AddTicks(1286), "Customer6" },
                    { new Guid("1dff6f90-3218-44ac-8c0f-64dc4839b638"), null, new DateTime(2024, 11, 24, 17, 57, 40, 415, DateTimeKind.Utc).AddTicks(5959), null, null, "Customer 3", null, "j70+px4CcpgNlxx0+u4kLReXYN7Kb+wSXZfAu7/WTX8CzS7v", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 415, DateTimeKind.Utc).AddTicks(5963), "Customer3" },
                    { new Guid("265ec730-f37c-4c8a-b334-9bd587e59fbd"), null, new DateTime(2024, 11, 24, 17, 57, 40, 426, DateTimeKind.Utc).AddTicks(8666), null, null, "Customer 7", null, "dveNkHLQAICMT6uuxgTAK2aHfv4GF9zVkDkfhv4lvsyCya8d", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 426, DateTimeKind.Utc).AddTicks(8666), "Customer7" },
                    { new Guid("276ab3f7-2e96-4b3e-9fd1-e94a323d8117"), null, new DateTime(2024, 11, 24, 17, 57, 40, 421, DateTimeKind.Utc).AddTicks(3824), null, null, "Customer 5", null, "SOMtZ4dBJ4JVch82uBU6yRP/hA3WYp/eD5ws7GDz47Xzm8ry", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 421, DateTimeKind.Utc).AddTicks(3825), "Customer5" },
                    { new Guid("52838559-5c0c-45cb-ac92-f88e72fd7e70"), null, new DateTime(2024, 11, 24, 17, 57, 40, 446, DateTimeKind.Utc).AddTicks(2086), null, null, "Customer 14", null, "2n0ikdoMkchyQ9ddtjXhEr9m8okiQUvC7ZQbtRugJhbTbpwy", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 446, DateTimeKind.Utc).AddTicks(2086), "Customer14" },
                    { new Guid("5737d160-fefb-416f-b291-ab53cbcf62b7"), null, new DateTime(2024, 11, 24, 17, 57, 40, 449, DateTimeKind.Utc).AddTicks(398), null, null, "Customer 15", null, "msBqN0g9LUudYexLkSBkqm1vzfMmCgDXB9Ss4aHPO85TQp0a", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 449, DateTimeKind.Utc).AddTicks(401), "Customer15" },
                    { new Guid("5b6041f7-ded3-4257-9c97-af60fdfce06c"), null, new DateTime(2024, 11, 24, 17, 57, 40, 429, DateTimeKind.Utc).AddTicks(6000), null, null, "Customer 8", null, "ZlcqWRZdOYOh1ZIIEXkrre+7MtsADs4kCRnCtpZ5f1wW6egq", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 429, DateTimeKind.Utc).AddTicks(6001), "Customer8" },
                    { new Guid("7f1edd88-ea8f-4d50-944b-277d35047376"), null, new DateTime(2024, 11, 24, 17, 57, 40, 409, DateTimeKind.Utc).AddTicks(7144), null, null, "Customer 1", null, "aD8GuXdvl5tI4NNVYMvXnzoAdB+Ken+6ITLgKxM1NapksSdE", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 409, DateTimeKind.Utc).AddTicks(7146), "Customer1" },
                    { new Guid("8b908bbe-2ad1-4aa8-8e16-3ef3f577859e"), null, new DateTime(2024, 11, 24, 17, 57, 40, 432, DateTimeKind.Utc).AddTicks(4199), null, null, "Customer 9", null, "ZovKir7yi9sPF0huE1AHz2Op2QljRzwE3aQA+8uzJ/Ga9c6b", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 432, DateTimeKind.Utc).AddTicks(4199), "Customer9" },
                    { new Guid("a86e9178-afe9-4aaf-8b4a-1059381d5699"), null, new DateTime(2024, 11, 24, 17, 57, 40, 443, DateTimeKind.Utc).AddTicks(4776), null, null, "Customer 13", null, "fzghfAIN9zVEg9E5YEmn0zfhaxxr3wn1wOToKFtjmexIqeIe", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 443, DateTimeKind.Utc).AddTicks(4777), "Customer13" },
                    { new Guid("f2fd2967-8017-4024-a03b-a273f9971a66"), null, new DateTime(2024, 11, 24, 17, 57, 40, 403, DateTimeKind.Utc).AddTicks(8318), null, null, "Admin 1", null, "qVChB0NNRjpdK1le3EeY0OISsp8Ev7JdywAzn/Vgtr7Vr0Td", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 17, 57, 40, 403, DateTimeKind.Utc).AddTicks(8319), "Admin1" },
                    { new Guid("fd43fc8a-8f1e-4dc7-8e56-1000ca7911a4"), null, new DateTime(2024, 11, 24, 17, 57, 40, 440, DateTimeKind.Utc).AddTicks(7240), null, null, "Customer 12", null, "oNFR5fQjydF/GL5mMevRjAiPwDf5fQDmK/31KozZ9wwbKbel", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 17, 57, 40, 440, DateTimeKind.Utc).AddTicks(7240), "Customer12" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0250cf6e-5d7c-4c54-ad02-022a2da5dab6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("17833b13-2d9e-4891-b66e-a6769a6255ea"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("17c12695-d177-4fab-9351-c6061c5575bb"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1b50e379-ab7c-481b-973f-a5ce11c0847e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1c1999ca-01b7-4936-bda9-ce1bf5671dd9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dd00cbb-9515-4a31-8efa-223e78a8919d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dff6f90-3218-44ac-8c0f-64dc4839b638"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("265ec730-f37c-4c8a-b334-9bd587e59fbd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("276ab3f7-2e96-4b3e-9fd1-e94a323d8117"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("52838559-5c0c-45cb-ac92-f88e72fd7e70"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5737d160-fefb-416f-b291-ab53cbcf62b7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5b6041f7-ded3-4257-9c97-af60fdfce06c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7f1edd88-ea8f-4d50-944b-277d35047376"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8b908bbe-2ad1-4aa8-8e16-3ef3f577859e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a86e9178-afe9-4aaf-8b4a-1059381d5699"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f2fd2967-8017-4024-a03b-a273f9971a66"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fd43fc8a-8f1e-4dc7-8e56-1000ca7911a4"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Transaction",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Post",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Deposit",
                table: "Post",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 31, 55, 556, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 11, 24, 16, 31, 55, 556, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 31, 55, 556, DateTimeKind.Utc).AddTicks(1392), new DateTime(2024, 11, 24, 16, 31, 55, 556, DateTimeKind.Utc).AddTicks(1392) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedDate", "Dob", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("0d41ed62-f11c-4359-a274-0820db174d3a"), null, new DateTime(2024, 11, 24, 16, 31, 55, 575, DateTimeKind.Utc).AddTicks(6380), null, null, "Customer 6", null, "UKu1WzmKvu6YDMwvc6Di+rdYNJhdwd+SLe6odutFPHzHJEiL", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 575, DateTimeKind.Utc).AddTicks(6380), "Customer6" },
                    { new Guid("164051b5-05a6-4537-8422-2f95f28b0dee"), null, new DateTime(2024, 11, 24, 16, 31, 55, 583, DateTimeKind.Utc).AddTicks(9851), null, null, "Customer 9", null, "yS7z+Z+8X77L9WMWyyQs3znxXE+wO1mmZAqyH30YErLnadl2", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 583, DateTimeKind.Utc).AddTicks(9851), "Customer9" },
                    { new Guid("16b67611-f69b-437e-87d2-c43726444e54"), null, new DateTime(2024, 11, 24, 16, 31, 55, 581, DateTimeKind.Utc).AddTicks(2218), null, null, "Customer 8", null, "AhmrEUsub2zGcjMToGyTOUnUFNyLz0jw5HwmVrC91Cga5JDK", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 581, DateTimeKind.Utc).AddTicks(2220), "Customer8" },
                    { new Guid("2046f97c-964c-40e3-9079-2519a1c8651a"), null, new DateTime(2024, 11, 24, 16, 31, 55, 592, DateTimeKind.Utc).AddTicks(3224), null, null, "Customer 12", null, "akQN65Ph9ZuFd91ogoUlsoxl6s7BZU4meuhcbbzz4Mq2BO35", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 592, DateTimeKind.Utc).AddTicks(3225), "Customer12" },
                    { new Guid("39fdab54-434b-458d-a906-2664afa782de"), null, new DateTime(2024, 11, 24, 16, 31, 55, 595, DateTimeKind.Utc).AddTicks(3085), null, null, "Customer 13", null, "55gXMvC7TBv9c/IQr5Op0eG/2M6uCv0HcNHHOri0/exKWTwD", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 595, DateTimeKind.Utc).AddTicks(3088), "Customer13" },
                    { new Guid("4312b50d-a8f6-4af1-963e-4554046e7f7c"), null, new DateTime(2024, 11, 24, 16, 31, 55, 586, DateTimeKind.Utc).AddTicks(7303), null, null, "Customer 10", null, "b/29AhnRuWVkko/+TScUQSPtniKansl1KoDGTNf2OzvXDb2Q", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 586, DateTimeKind.Utc).AddTicks(7303), "Customer10" },
                    { new Guid("436f062d-fcba-4010-b045-6d57a4c244e9"), null, new DateTime(2024, 11, 24, 16, 31, 55, 572, DateTimeKind.Utc).AddTicks(9046), null, null, "Customer 5", null, "gLefSI60VXYuj9xgnrhdCAEdUyryWeBPpgoTbBvzMhXymff9", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 572, DateTimeKind.Utc).AddTicks(9046), "Customer5" },
                    { new Guid("590b72e7-152d-4b73-9c53-364a831bfc2b"), null, new DateTime(2024, 11, 24, 16, 31, 55, 567, DateTimeKind.Utc).AddTicks(3173), null, null, "Customer 3", null, "Thdi3i5V8IuyiWsm3TcFf8C2AVK3soL4xzLEFMMedU0Lfqi3", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 567, DateTimeKind.Utc).AddTicks(3174), "Customer3" },
                    { new Guid("59729a30-4b6d-4d75-abab-4d657e76dc25"), null, new DateTime(2024, 11, 24, 16, 31, 55, 578, DateTimeKind.Utc).AddTicks(3813), null, null, "Customer 7", null, "luiO+ImDZucnP6JcLcXeVdTOk/Y5uDntgaIdbCxfzVXXrtZL", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 578, DateTimeKind.Utc).AddTicks(3813), "Customer7" },
                    { new Guid("6722eb35-3f74-4a70-9f2e-a0be5b80debf"), null, new DateTime(2024, 11, 24, 16, 31, 55, 556, DateTimeKind.Utc).AddTicks(1523), null, null, "Admin 1", null, "iFmI6rpDXtyfU3HmAyz36LuCs4ySDIkhMcZBsbFiBE/1QQuW", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 16, 31, 55, 556, DateTimeKind.Utc).AddTicks(1523), "Admin1" },
                    { new Guid("6fd9d888-fae7-446a-a969-f106711d166a"), null, new DateTime(2024, 11, 24, 16, 31, 55, 561, DateTimeKind.Utc).AddTicks(7641), null, null, "Customer 1", null, "uU7Y2wTUsFhnepX+K0SQQVmPqnQNf8HOsMLZqlDljPd8KZjZ", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 561, DateTimeKind.Utc).AddTicks(7644), "Customer1" },
                    { new Guid("78421daf-d7a0-490a-a9e1-5a65b044ed83"), null, new DateTime(2024, 11, 24, 16, 31, 55, 570, DateTimeKind.Utc).AddTicks(844), null, null, "Customer 4", null, "4DB06kgqx8/hgEl9NK43Bn04C4ipZqmWNgmv5LYGugBsNWw1", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 570, DateTimeKind.Utc).AddTicks(845), "Customer4" },
                    { new Guid("83495983-2957-45af-adcb-7e29cbbb051e"), null, new DateTime(2024, 11, 24, 16, 31, 55, 600, DateTimeKind.Utc).AddTicks(7864), null, null, "Customer 15", null, "fFOofTnQkbTypM8X92XJ+IMQaSZehTqvm9l5p5lvto5QNDFH", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 600, DateTimeKind.Utc).AddTicks(7864), "Customer15" },
                    { new Guid("8dcb57f1-e75d-4fd3-b9ab-88e61f6cdb89"), null, new DateTime(2024, 11, 24, 16, 31, 55, 564, DateTimeKind.Utc).AddTicks(5526), null, null, "Customer 2", null, "PqUracNwtA34Il7gvpJp0BnB9evGU5SRit7OnQgR2e4bpRxA", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 564, DateTimeKind.Utc).AddTicks(5526), "Customer2" },
                    { new Guid("8ea53a34-702f-4112-b70a-0d836d4b16e5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 598, DateTimeKind.Utc).AddTicks(565), null, null, "Customer 14", null, "t/htBCHJK+Wljk6VszXyoGdCaE5nsnUcOsIWj0/c2xu64Ot1", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 598, DateTimeKind.Utc).AddTicks(566), "Customer14" },
                    { new Guid("915905ba-f8a2-47e8-a619-5c426379e81f"), null, new DateTime(2024, 11, 24, 16, 31, 55, 558, DateTimeKind.Utc).AddTicks(9170), null, null, "Admin 2", null, "FI2dqNLlWd9oyuQ25rJWkXL0ERp8Tx2Jii8qkCKv2OEW2ovM", "123456789", new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"), null, new DateTime(2024, 11, 24, 16, 31, 55, 558, DateTimeKind.Utc).AddTicks(9171), "Admin2" },
                    { new Guid("b855f2cc-c03c-4b08-8b8e-b07440c681a6"), null, new DateTime(2024, 11, 24, 16, 31, 55, 589, DateTimeKind.Utc).AddTicks(5091), null, null, "Customer 11", null, "hV3R8RffUx4AKiY9mMt7gQFIbZezBlYPJOclg6rpiMMVIVQO", "123456789", new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"), null, new DateTime(2024, 11, 24, 16, 31, 55, 589, DateTimeKind.Utc).AddTicks(5092), "Customer11" }
                });
        }
    }
}
