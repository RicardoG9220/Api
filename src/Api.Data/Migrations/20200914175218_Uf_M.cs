using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Uf_M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bbef0fb1-5722-4912-8d60-996216eeb3f4"));

            migrationBuilder.InsertData(
                table: "Uf",
                columns: new[] { "Id", "CreateAt", "Nome", "Sigla", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5065), "Acre", "AC", null },
                    { new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5254), "São Paulo", "SP", null },
                    { new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5251), "Sergipe", "SE", null },
                    { new Guid("b81f95e0-f226-4afd-9763-290001637ed4"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5247), "Santa Catarina", "SC", null },
                    { new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5161), "Rio Grande do Sul", "RS", null },
                    { new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5159), "Roraima", "RR", null },
                    { new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5157), "Rondônia", "RO", null },
                    { new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5155), "Rio Grande do Norte", "RN", null },
                    { new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5152), "Rio de Janeiro", "RJ", null },
                    { new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5150), "Paraná", "PR", null },
                    { new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5148), "Piauí", "PI", null },
                    { new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5146), "Pernambuco", "PE", null },
                    { new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5143), "Paraíba", "PB", null },
                    { new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5141), "Pará", "PA", null },
                    { new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5139), "Mato Grosso", "MT", null },
                    { new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5137), "Mato Grosso do Sul", "MS", null },
                    { new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5135), "Minas Gerais", "MG", null },
                    { new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5133), "Maranhão", "MA", null },
                    { new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5130), "Goiás", "GO", null },
                    { new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5128), "Espírito Santo", "ES", null },
                    { new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5125), "Distrito Federal", "DF", null },
                    { new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5123), "Ceará", "CE", null },
                    { new Guid("5abca453-d035-4766-a81b-9f73d683a54b"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5121), "Bahia", "BA", null },
                    { new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5119), "Amapá", "AP", null },
                    { new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5116), "Amazonas", "AM", null },
                    { new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5111), "Alagoas", "AL", null },
                    { new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"), new DateTime(2020, 9, 14, 17, 52, 17, 963, DateTimeKind.Utc).AddTicks(5257), "Tocantins", "TO", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("6ccc8b64-2137-4e9e-bf34-ac2e12c752f9"), new DateTime(2020, 9, 14, 14, 52, 17, 960, DateTimeKind.Local).AddTicks(2600), "admin@email.com", "Admin", new DateTime(2020, 9, 14, 14, 52, 17, 961, DateTimeKind.Local).AddTicks(2310) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"));

            migrationBuilder.DeleteData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6ccc8b64-2137-4e9e-bf34-ac2e12c752f9"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("bbef0fb1-5722-4912-8d60-996216eeb3f4"), new DateTime(2020, 9, 9, 20, 25, 29, 855, DateTimeKind.Local).AddTicks(1603), "admin@email.com", "Admin", new DateTime(2020, 9, 9, 20, 25, 29, 856, DateTimeKind.Local).AddTicks(286) });
        }
    }
}
