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
            migrationBuilder.DropIndex(
                name: "IX_Transaction_PostId",
                table: "Transaction");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13ebfc3b-a208-48b2-bf17-eafbb47c8abf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("25094731-0dd2-4e34-b0b1-cc4f12d1218e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("285c2b83-1372-4f7e-a4f1-9ba5d285f745"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2a226b52-85e3-4980-b351-44c63c041a23"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("343f69d9-58df-4138-9eed-e1c57d57c1c9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("487c1f41-09ef-4709-a973-baf9791b2496"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4942612a-10d2-4256-b7c1-7cfc9fcc8606"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6e8855fe-c1ea-42ff-9773-f46d05d02f8c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6ea8b671-c546-48c4-8f33-b822d4ea90a1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8cb777ea-ed9b-4336-9feb-48deb536dfa1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4de10b4-0586-46c9-8b21-fcd06ac6aff3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c2b8dfee-321b-4bf6-8a45-ccff991d3315"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c792280c-0307-4dcd-ad2b-5c2e8bbfc99f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca24526e-bda1-43db-9ad7-49a03672a13d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d86248fb-ea9b-4fcd-b662-194148cd95c9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e2a039fe-a42f-47d2-a449-f95972ff9630"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ead045a4-784d-4355-930c-88f97a4c1f3c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "PostId",
                table: "Transaction",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PostId",
                table: "Transaction",
                column: "PostId",
                unique: true,
                filter: "[PostId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transaction_PostId",
                table: "Transaction");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "PostId",
                table: "Transaction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(1881), new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(1894), new DateTime(2024, 11, 24, 16, 22, 36, 681, DateTimeKind.Utc).AddTicks(1894) });

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
                name: "IX_Transaction_PostId",
                table: "Transaction",
                column: "PostId",
                unique: true);
        }
    }
}
