using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EProdajaRacunarskeOpreme.WebApi.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 1, 13, 1, 7, 49, 618, DateTimeKind.Local).AddTicks(7137), "Tcpif8npRcbIonB51WyTfif8hpE=", "ojMhiUOHHe0NY+zAE0BEMg==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 1, 13, 1, 7, 49, 686, DateTimeKind.Local).AddTicks(388), "5ZW4f+onSuxLoHdyJ11IZtNn9mo=", "etYKLgPG02uOAK6V3BTPaQ==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 1, 13, 1, 7, 49, 686, DateTimeKind.Local).AddTicks(3500), "rhh8wf9T9V6yoBKpiWI9wzrdInE=", "WS0kxectOG/Tch7EHVUJOg==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "Tcpif8npRcbIonB51WyTfif8hpE=", "ojMhiUOHHe0NY+zAE0BEMg==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "Tcpif8npRcbIonB51WyTfif8hpE=", "ojMhiUOHHe0NY+zAE0BEMg==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 1, 13, 1, 7, 49, 690, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.InsertData(
                table: "KorisniciUloge",
                columns: new[] { "KorisnikUlogaId", "DatumIzmjene", "KorisnikId", "UlogaId" },
                values: new object[] { 2, new DateTime(2022, 1, 13, 1, 7, 49, 690, DateTimeKind.Local).AddTicks(5880), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 7, 49, 691, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 7, 49, 692, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 7, 49, 692, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 7, 49, 694, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 7, 49, 694, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 7, 49, 695, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 7, 49, 696, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 1, 13, 1, 7, 49, 696, DateTimeKind.Local).AddTicks(1107));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "+YwfisyR7nWzK9uyShpPOI2j8yI=", "aS5rF6/5YRhh3SSF0jCWsA==" });

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
        }
    }
}
