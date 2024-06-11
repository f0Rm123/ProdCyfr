using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProduktCyfrowy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Reservations = table.Column<string>(type: "TEXT", nullable: false),
                    ComputersAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    NumberOfSeats = table.Column<string>(type: "TEXT", nullable: false),
                    RoomSupervisor = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
