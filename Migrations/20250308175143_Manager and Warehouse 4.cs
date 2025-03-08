using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockPulse.Migrations
{
    /// <inheritdoc />
    public partial class ManagerandWarehouse4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Manager_managerId",
                table: "Warehouse");

            migrationBuilder.RenameColumn(
                name: "managerId",
                table: "Warehouse",
                newName: "ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouse_managerId",
                table: "Warehouse",
                newName: "IX_Warehouse_ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Manager_ManagerId",
                table: "Warehouse",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Manager_ManagerId",
                table: "Warehouse");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Warehouse",
                newName: "managerId");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouse_ManagerId",
                table: "Warehouse",
                newName: "IX_Warehouse_managerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Manager_managerId",
                table: "Warehouse",
                column: "managerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
