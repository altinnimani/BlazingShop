using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingShop.Server.Migrations
{
    public partial class UpdatedQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 1 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 4 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 5 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 6 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 7 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 6, 7 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 7, 7 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 8 },
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 9 },
                column: "Quantity",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 1 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 4 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 5 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 6 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 7 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 6, 7 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 7, 7 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 8 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 9 },
                column: "Quantity",
                value: 1);
        }
    }
}
