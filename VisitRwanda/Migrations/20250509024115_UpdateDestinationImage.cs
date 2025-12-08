using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitRwanda.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDestinationImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 4,
                column: "Image",
                value: "AkageraView.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationID",
                keyValue: 4,
                column: "Image",
                value: "Akagera.jpg");
        }
    }
}
