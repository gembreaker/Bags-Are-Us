using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp2020.Shared.Migrations
{
    public partial class AddFK_PaymentTypeCustomerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "PaymentType",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_PaymentType_CustomerID",
                table: "PaymentType",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentType_AspNetUsers_CustomerID",
                table: "PaymentType",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentType_AspNetUsers_CustomerID",
                table: "PaymentType");

            migrationBuilder.DropIndex(
                name: "IX_PaymentType_CustomerID",
                table: "PaymentType");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "PaymentType",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
