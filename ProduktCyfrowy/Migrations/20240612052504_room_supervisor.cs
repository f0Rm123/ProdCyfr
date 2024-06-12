using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProduktCyfrowy.Migrations
{
    /// <inheritdoc />
    public partial class room_supervisor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SupervisorId",
                table: "Rooms",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_SupervisorId",
                table: "Rooms",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Users_SupervisorId",
                table: "Rooms",
                column: "SupervisorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Users_SupervisorId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_SupervisorId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "Rooms");
        }
    }
}
