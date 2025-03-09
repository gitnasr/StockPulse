using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockPulse.Migrations
{
    /// <inheritdoc />
    public partial class RemoveStockFromUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Stocks_StockWarehouseId_StockCode",
                table: "Units");

            migrationBuilder.AlterColumn<int>(
                name: "StockWarehouseId",
                table: "Units",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Units",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Stocks_StockWarehouseId_StockCode",
                table: "Units",
                columns: new[] { "StockWarehouseId", "StockCode" },
                principalTable: "Stocks",
                principalColumns: new[] { "WarehouseId", "Code" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Stocks_StockWarehouseId_StockCode",
                table: "Units");

            migrationBuilder.AlterColumn<int>(
                name: "StockWarehouseId",
                table: "Units",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Units",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Stocks_StockWarehouseId_StockCode",
                table: "Units",
                columns: new[] { "StockWarehouseId", "StockCode" },
                principalTable: "Stocks",
                principalColumns: new[] { "WarehouseId", "Code" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
