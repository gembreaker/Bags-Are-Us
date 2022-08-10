using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp2020.Shared.Migrations
{
    public partial class ScaffoldAspNetIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Addresses",
            //    columns: table => new
            //    {
            //        AddressID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Line1 = table.Column<string>(maxLength: 100, nullable: false),
            //        Line2 = table.Column<string>(maxLength: 100, nullable: true),
            //        City = table.Column<string>(maxLength: 50, nullable: false),
            //        Postcode = table.Column<string>(maxLength: 8, nullable: false),
            //        Country = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AddressID", x => x.AddressID);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "BagType",
            //    columns: table => new
            //    {
            //        BagTypeID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        BagType = table.Column<string>(maxLength: 25, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BagType", x => x.BagTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Colour",
            //    columns: table => new
            //    {
            //        ColourID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ColourName = table.Column<string>(maxLength: 25, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Colour", x => x.ColourID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PaymentType",
            //    columns: table => new
            //    {
            //        PaymentTypeID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CustomerID = table.Column<int>(nullable: false),
            //        PaymentMethod = table.Column<string>(maxLength: 50, nullable: false),
            //        NameOnCard = table.Column<string>(maxLength: 50, nullable: false),
            //        CardNumber = table.Column<int>(nullable: false),
            //        ExpirationDate = table.Column<string>(maxLength: 8, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PaymentType", x => x.PaymentTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RangeType",
            //    columns: table => new
            //    {
            //        RangeID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        RangeName = table.Column<string>(maxLength: 25, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RangeID", x => x.RangeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CustomerAddresses",
            //    columns: table => new
            //    {
            //        AddressID = table.Column<int>(nullable: false),
            //        CustomerID = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CustomerAddresses", x => new { x.AddressID, x.CustomerID });
            //        table.ForeignKey(
            //            name: "FK_AddressID",
            //            column: x => x.AddressID,
            //            principalTable: "Addresses",
            //            principalColumn: "AddressID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "OrderDetails",
            //    columns: table => new
            //    {
            //        OrderID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CustomerID = table.Column<int>(nullable: false),
            //        PaymentTypeID = table.Column<int>(nullable: true),
            //        DateOrdered = table.Column<DateTime>(nullable: false),
            //        DatePurchased = table.Column<DateTime>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderID", x => x.OrderID);
            //        table.ForeignKey(
            //            name: "FK_PaymentTypeID",
            //            column: x => x.PaymentTypeID,
            //            principalTable: "PaymentType",
            //            principalColumn: "PaymentTypeID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductDetails",
            //    columns: table => new
            //    {
            //        ProductCode = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ProductName = table.Column<string>(maxLength: 100, nullable: false),
            //        Description = table.Column<string>(maxLength: 255, nullable: true),
            //        ColourID = table.Column<int>(nullable: true),
            //        ProductImage = table.Column<string>(maxLength: 50, nullable: true),
            //        Price = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
            //        RangeID = table.Column<int>(nullable: true),
            //        BagTypeID = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductCode", x => x.ProductCode);
            //        table.ForeignKey(
            //            name: "FK_BagTypeID",
            //            column: x => x.BagTypeID,
            //            principalTable: "BagType",
            //            principalColumn: "BagTypeID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ColourID",
            //            column: x => x.ColourID,
            //            principalTable: "Colour",
            //            principalColumn: "ColourID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_RangeID",
            //            column: x => x.RangeID,
            //            principalTable: "RangeType",
            //            principalColumn: "RangeID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductOrderDetails",
            //    columns: table => new
            //    {
            //        OrderID = table.Column<int>(nullable: false),
            //        ProductID = table.Column<int>(nullable: false),
            //        Quantity = table.Column<int>(nullable: false),
            //        UnitPrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
            //        TotalPrice = table.Column<decimal>(type: "decimal(29, 0)", nullable: true, computedColumnSql: "([Quantity]*[UnitPrice])")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductOrderDetails", x => new { x.OrderID, x.ProductID });
            //        table.ForeignKey(
            //            name: "FK_OrderID",
            //            column: x => x.OrderID,
            //            principalTable: "OrderDetails",
            //            principalColumn: "OrderID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductID",
            //            column: x => x.ProductID,
            //            principalTable: "ProductDetails",
            //            principalColumn: "ProductCode",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderDetails_PaymentTypeID",
            //    table: "OrderDetails",
            //    column: "PaymentTypeID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductDetails_BagTypeID",
            //    table: "ProductDetails",
            //    column: "BagTypeID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductDetails_ColourID",
            //    table: "ProductDetails",
            //    column: "ColourID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductDetails_RangeID",
            //    table: "ProductDetails",
            //    column: "RangeID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductOrderDetails_ProductID",
            //    table: "ProductOrderDetails",
            //    column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CustomerAddresses");

            migrationBuilder.DropTable(
                name: "ProductOrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "BagType");

            migrationBuilder.DropTable(
                name: "Colour");

            migrationBuilder.DropTable(
                name: "RangeType");
        }
    }
}
