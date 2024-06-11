using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProduktCyfrowy.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOfSeats",
                table: "Rooms",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumberOfSeats",
                table: "Rooms",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
