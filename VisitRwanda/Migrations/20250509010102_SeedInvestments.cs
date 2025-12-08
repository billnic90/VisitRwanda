using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VisitRwanda.Migrations
{
    /// <inheritdoc />
    public partial class SeedInvestments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 1,
                column: "Image",
                value: "CultureTraditions.png");

            migrationBuilder.InsertData(
                table: "Investments",
                columns: new[] { "InvestmentID", "Description", "Image", "Requirements", "Sector" },
                values: new object[,]
                {
                    { 1, "Modern tea‑plantation projects expanding Rwanda’s exports and promoting sustainable farming.", "Agriculture.jpg", "Minimum investment of $100,000 and partnership with local cooperatives.", "Agriculture" },
                    { 2, "An ICT hub in Kigali offering tax incentives and world class digital infrastructure.", "Technology.jpg", "Registration with Rwanda Development Board and local office setup.", "Technology" },
                    { 3, "Eco lodge developments near national parks to boost eco tourism and conservation.", "Tourism.jpg", "Environmental impact assessment approval.", "Tourism" },
                    { 4, "Light manufacturing parks in the Kigali Special Economic Zone with streamlined customs.", "Manufacturing.png", "Land lease agreement and compliance with factory standards.", "Manufacturing" },
                    { 5, "Rwanda is pioneering renewable technologies, with a methane gas plant on Lake Kivu supplying 14% of our energy requirements, and a growing solar sector.", "Energy.jpg", "Partnerships with local energy providers and RDB registration.", "Energy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Investments",
                keyColumn: "InvestmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Investments",
                keyColumn: "InvestmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Investments",
                keyColumn: "InvestmentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Investments",
                keyColumn: "InvestmentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Investments",
                keyColumn: "InvestmentID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Cultures",
                keyColumn: "CultureID",
                keyValue: 1,
                column: "Image",
                value: "CultureTraditions.jpg");
        }
    }
}
