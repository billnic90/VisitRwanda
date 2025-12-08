using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VisitRwanda.Migrations
{
    /// <inheritdoc />
    public partial class SeedCultures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cultures",
                columns: new[] { "CultureID", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "Rwandan culture has many traditions…", "CultureTraditions.jpg", "Rwandan Culture and Traditions" },
                    { 2, "Formerly the Presidential Palace Museum…", "RwandaArtMuseum.jpg", "Rwanda Art Museum" },
                    { 3, "The Kigali Genocide Memorial at Gisozi…", "KigaliGenocide.jpg", "Kigali Genocide Memorial" },
                    { 4, "The Kandt House Museum looks at colonialism…", "KandtHouse.jpg", "Kandt House Museum" },
                    { 5, "Today Kigali hosts two fashion festivals…", "FashionStyle.jpg", "Fashion & Style" }
                });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 2,
                column: "Description",
                value: "Home to the King's Palace a reconstruction of the traditional royal residence, a beautifully crafted thatched dwelling shaped like a beehive.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 2,
                column: "Description",
                value: "Home to the King's Palace—a reconstruction of the traditional royal residence, a beautifully-crafted thatched dwelling shaped like a beehive.");
        }
    }
}
