using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlyWiseBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddTicketPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Ticekts",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ticekts");
        }
    }
}
