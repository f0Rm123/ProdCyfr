using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProduktCyfrowy.Migrations
{
    /// <inheritdoc />
    public partial class remove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomSupervisor",
                table: "Rooms");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoomSupervisor",
                table: "Rooms",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
