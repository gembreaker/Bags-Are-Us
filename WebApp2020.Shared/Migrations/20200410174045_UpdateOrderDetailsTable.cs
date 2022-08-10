using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp2020.Shared.Migrations
{
    public partial class UpdateOrderDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_BagTypeID",
            //    table: "ProductDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ColourID",
            //    table: "ProductDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_RangeID",
            //    table: "ProductDetails");

            //migrationBuilder.AlterColumn<int>(
            //    name: "RangeID",
            //    table: "ProductDetails",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "ColourID",
            //    table: "ProductDetails",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "BagTypeID",
            //    table: "ProductDetails",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductCode",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                nullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "AspNetUserTokens",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserTokens",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProviderKey",
            //    table: "AspNetUserLogins",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserLogins",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductCode",
                table: "OrderDetails",
                column: "ProductCode");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductDetails_ProductCode",
                table: "OrderDetails",
                column: "ProductCode",
                principalTable: "ProductDetails",
                principalColumn: "ProductCode",
                onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_BagTypeID",
            //    table: "ProductDetails",
            //    column: "BagTypeID",
            //    principalTable: "BagType",
            //    principalColumn: "BagTypeID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ColourID",
            //    table: "ProductDetails",
            //    column: "ColourID",
            //    principalTable: "Colour",
            //    principalColumn: "ColourID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_RangeID",
            //    table: "ProductDetails",
            //    column: "RangeID",
            //    principalTable: "RangeType",
            //    principalColumn: "RangeID",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductDetails_ProductCode",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BagTypeID",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ColourID",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_RangeID",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductCode",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "RangeID",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ColourID",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BagTypeID",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(int));

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "AspNetUserTokens",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserTokens",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProviderKey",
            //    table: "AspNetUserLogins",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserLogins",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 128);

            migrationBuilder.AddForeignKey(
                name: "FK_BagTypeID",
                table: "ProductDetails",
                column: "BagTypeID",
                principalTable: "BagType",
                principalColumn: "BagTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ColourID",
                table: "ProductDetails",
                column: "ColourID",
                principalTable: "Colour",
                principalColumn: "ColourID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RangeID",
                table: "ProductDetails",
                column: "RangeID",
                principalTable: "RangeType",
                principalColumn: "RangeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
