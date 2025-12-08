using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VisitRwanda.Migrations
{
    /// <inheritdoc />
    public partial class SeedDestinations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationID", "Description", "Image", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "One of the oldest rainforests in Africa, Nyungwe is rich in biodiversity and spectacularly beautiful. The mountainous region is teaming with wildlife, including a small population of chimpanzees as well as 12 other species of primate.", "Nyungwe.jpg", "Southern Province", "Nyungwe National Park" },
                    { 2, "Home to the King's Palace—a reconstruction of the traditional royal residence, a beautifully-crafted thatched dwelling shaped like a beehive.", "Nyanza.jpg", "Southern Province", "Nyanza" },
                    { 3, "Part of Africa’s Great Rift Valley, Lake Kivu is dotted with islands and inlets along its shoreline, with charming beach resorts, spectacular vistas and plenty of opportunities for hiking and cycling.", "LakeKivu.jpg", "Western Province", "Lake Kivu" },
                    { 4, "The relatively warm and low‑lying plains of Akagera comprise savannah, woodland, wetland and a dozen lakes. In partnership with African Parks, we have reintroduced lions and rhinos, meaning once again visitors can hope to see the Big Five on safari drives.", "Akagera.jpg", "Eastern Province", "Akagera National Park" },
                    { 5, "“In the heart of Central Africa, so high up that you shiver more than you sweat,” wrote Dian Fossey. “Great, old volcanoes towering almost 15,000 feet, nearly covered with rich, green rainforest—the Virungas.”", "Volcanoes.jpg", "Northern Province", "Volcanoes National Park" },
                    { 6, "The capital city is pleasantly low key yet dynamic and progressive. It's green, clean and safe with meaningful culture and remarkable drive.", "Kigali.jpg", "Kigali", "Kigali" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 6);
        }
    }
}
