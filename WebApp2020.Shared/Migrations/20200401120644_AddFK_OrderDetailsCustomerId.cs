using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp2020.Shared.Migrations
{
    public partial class AddFK_OrderDetailsCustomerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "OrderDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CustomerID",
                table: "OrderDetails",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_AspNetUsers_CustomerID",
                table: "OrderDetails",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_AspNetUsers_CustomerID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_CustomerID",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
