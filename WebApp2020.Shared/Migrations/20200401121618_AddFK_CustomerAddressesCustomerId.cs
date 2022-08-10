using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp2020.Shared.Migrations
{
    public partial class AddFK_CustomerAddressesCustomerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "CustomerAddresses",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
               name: "IX_CustomerAddresses_CustomerID",
               table: "CustomerAddresses",
               column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_AspNetUsers_CustomerID",
                table: "CustomerAddresses",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
               name: "FK_CustomerAddresses_AspNetUsers_CustomerID",
               table: "CustomerAddresses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddresses_CustomerID",
                table: "CustomerAddresses");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "CustomerAddresses",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
