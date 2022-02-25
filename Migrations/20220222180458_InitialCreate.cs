using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerName = table.Column<string>(type: "nvarchar (30)", maxLength: 30, nullable: false),
                    PostCode = table.Column<string>(type: "STRING", nullable: false),
                    City = table.Column<string>(type: "STRING", nullable: false),
                    PhoneNumber = table.Column<int>(type: "INT", nullable: false),
                    Address = table.Column<string>(type: "STRING", nullable: false),
                    EmailAddress = table.Column<string>(type: "STRING", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerName);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: true),
                    ItemPrice = table.Column<double>(type: "REAL", nullable: false),
                    DateTaken = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Event = table.Column<string>(type: "TEXT", nullable: true),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "TEXT", nullable: false),
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    OrderSuccessful = table.Column<bool>(type: "INTEGER", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "ImagesOrders",
                columns: table => new
                {
                    ImageItemID = table.Column<int>(type: "INTEGER", nullable: false),
                    OrdersOrderID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesOrders", x => new { x.ImageItemID, x.OrdersOrderID });
                    table.ForeignKey(
                        name: "FK_ImagesOrders_Images_ImageItemID",
                        column: x => x.ImageItemID,
                        principalTable: "Images",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImagesOrders_Orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "Address",
                table: "Customers",
                column: "Address");

            migrationBuilder.CreateIndex(
                name: "CustomerName",
                table: "Customers",
                column: "CustomerName");

            migrationBuilder.CreateIndex(
                name: "EmailAddress",
                table: "Customers",
                column: "EmailAddress");

            migrationBuilder.CreateIndex(
                name: "PhoneNumber",
                table: "Customers",
                column: "PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "PostCode",
                table: "Customers",
                column: "PostCode");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesOrders_OrdersOrderID",
                table: "ImagesOrders",
                column: "OrdersOrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ImagesOrders");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
