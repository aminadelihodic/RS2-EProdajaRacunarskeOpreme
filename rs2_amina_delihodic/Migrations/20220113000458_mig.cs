using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EProdajaRacunarskeOpreme.WebApi.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 1, 13, 1, 4, 52, 705, DateTimeKind.Local).AddTicks(6870), "+YwfisyR7nWzK9uyShpPOI2j8yI=", "aS5rF6/5YRhh3SSF0jCWsA==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 1, 13, 1, 4, 52, 753, DateTimeKind.Local).AddTicks(7213), "3r7L/ZVQ9yzVbvh1HznLQKaDvbo=", "RTlZeSWxi2y6pDJXLsIIkw==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 1, 13, 1, 4, 52, 753, DateTimeKind.Local).AddTicks(9678), "cfs8H0ZM9H4Izcpgx00p7H46fiE=", "2X5zcYMKUHSPZbB5YmEqQA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "+YwfisyR7nWzK9uyShpPOI2j8yI=", "aS5rF6/5YRhh3SSF0jCWsA==" });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "KorisnikId", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Status", "Telefon" },
                values: new object[] { 2, "prodavac@mail.com", "Prodavac", "prodavac", "+YwfisyR7nWzK9uyShpPOI2j8yI=", "aS5rF6/5YRhh3SSF0jCWsA==", "Prodavac", false, "063232983" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 1, 13, 1, 4, 52, 757, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 4, 52, 758, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 4, 52, 759, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 4, 52, 759, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 4, 52, 776, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 4, 52, 777, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 4, 52, 778, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 4, 52, 778, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 4, 52, 778, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogaId", "Naziv", "Opis" },
                values: new object[] { 2, "Prodavac", "Upravljanje robom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "UlogaId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 12, 22, 4, 11, 34, 146, DateTimeKind.Local).AddTicks(7169), "JoTYUaqwSDdC7cAi0qcNFP54+gY=", "ud+7iMA8h0W9dp7yxFOTNw==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 12, 22, 4, 11, 34, 174, DateTimeKind.Local).AddTicks(8718), "9uoG/z0puU/kxxevh6qPhGDB/ws=", "cY1Dl9/hU9iImytH3Wqwjg==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 12, 22, 4, 11, 34, 175, DateTimeKind.Local).AddTicks(511), "8glAbeunvL3Gc6lOVsXeWJmmiXA=", "dNU/0auhzha7WRNOZUDdeg==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "JoTYUaqwSDdC7cAi0qcNFP54+gY=", "ud+7iMA8h0W9dp7yxFOTNw==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2021, 12, 22, 4, 11, 34, 176, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 12, 22, 4, 11, 34, 177, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 12, 22, 4, 11, 34, 177, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2021, 12, 22, 4, 11, 34, 177, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 12, 22, 4, 11, 34, 178, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 12, 22, 4, 11, 34, 178, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 12, 22, 4, 11, 34, 179, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 12, 22, 4, 11, 34, 179, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2021, 12, 22, 4, 11, 34, 179, DateTimeKind.Local).AddTicks(7839));
        }
    }
}
