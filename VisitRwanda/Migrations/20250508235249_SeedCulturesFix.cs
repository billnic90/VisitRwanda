using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitRwanda.Migrations
{
    /// <inheritdoc />
    public partial class SeedCulturesFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 1,
                column: "Description",
                value: "Rwandan culture has many traditions including traditional Intore dancing, basketry and Umuganda.");

            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 2,
                column: "Description",
                value: "Formerly the Presidential Palace Museum, this new museum displays contemporary artworks from Rwanda as well as abroad.It hosts temporary and travelling exhibitions alongside the permanent collection.");

            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 3,
                column: "Description",
                value: "The Kigali Genocide Memorial at Gisozi is where 250,000 victims have been buried. This memorial also serves to educate about how the 1994 Genocide against the Tutsi took shape and examines genocide in the 20th century. ");

            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 4,
                column: "Description",
                value: "The Kandt House Museum looks at colonialism in relation to Rwanda, set in the old house of the first colonial governor.");

            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 5,
                column: "Description",
                value: "Though it would have been a pipe dream some years ago, today Kigali is cosmopolitan enough to host not one, but two fashion festivals every year, and for fashionistas and those on the cutting edge of style, they offer a fantastic opportunity to see the cultural fusion of western and Rwandan styles that the country’s finest designers negotiate and create daily. Kigali Fashion Week takes place every July, and hosts dozens of international, local, and upcoming young designers, while the Rwanda Cultural Fashion Week showcases even more local and international talent every September.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 1,
                column: "Description",
                value: "Rwandan culture has many traditions…");

            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 2,
                column: "Description",
                value: "Formerly the Presidential Palace Museum…");

            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 3,
                column: "Description",
                value: "The Kigali Genocide Memorial at Gisozi…");

            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 4,
                column: "Description",
                value: "The Kandt House Museum looks at colonialism…");

            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 5,
                column: "Description",
                value: "Today Kigali hosts two fashion festivals…");
        }
    }
}
