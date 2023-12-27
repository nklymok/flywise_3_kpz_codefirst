using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlyWiseBackend.Migrations
{
    /// <inheritdoc />
    public partial class RenameTicketTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticekts_Airplanes_AirplaneId",
                table: "Ticekts");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticekts_Passengers_PassengerId",
                table: "Ticekts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticekts",
                table: "Ticekts");

            migrationBuilder.RenameTable(
                name: "Ticekts",
                newName: "Tickets");

            migrationBuilder.RenameIndex(
                name: "IX_Ticekts_PassengerId",
                table: "Tickets",
                newName: "IX_Tickets_PassengerId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticekts_AirplaneId",
                table: "Tickets",
                newName: "IX_Tickets_AirplaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Airplanes_AirplaneId",
                table: "Tickets",
                column: "AirplaneId",
                principalTable: "Airplanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Passengers_PassengerId",
                table: "Tickets",
                column: "PassengerId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Airplanes_AirplaneId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Passengers_PassengerId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticekts");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_PassengerId",
                table: "Ticekts",
                newName: "IX_Ticekts_PassengerId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_AirplaneId",
                table: "Ticekts",
                newName: "IX_Ticekts_AirplaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticekts",
                table: "Ticekts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticekts_Airplanes_AirplaneId",
                table: "Ticekts",
                column: "AirplaneId",
                principalTable: "Airplanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticekts_Passengers_PassengerId",
                table: "Ticekts",
                column: "PassengerId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
