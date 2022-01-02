using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerName = table.Column<string>(type: "nvarchar (30)", maxLength: 30, nullable: false),
                    PostCode = table.Column<string>(type: "STRING", nullable: false),
                    PhoneNumber = table.Column<int>(type: "INT", nullable: false),
                    Address = table.Column<string>(type: "STRING", nullable: false),
                    EmailAddress = table.Column<string>(type: "STRING", nullable: false),
                    CustomersViewModelCustomerName = table.Column<string>(type: "nvarchar (30)", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerName);
                    table.ForeignKey(
                        name: "FK_Customers_Customers_CustomersViewModelCustomerName",
                        column: x => x.CustomersViewModelCustomerName,
                        principalTable: "Customers",
                        principalColumn: "CustomerName");
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ItemNumber = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: true),
                    ItemPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    DateTaken = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Event = table.Column<string>(type: "TEXT", nullable: true),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ItemNumber);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderNumber = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderNumber);
                });

            migrationBuilder.CreateTable(
                name: "CustomersViewModelOrders",
                columns: table => new
                {
                    CustomersCustomerName = table.Column<string>(type: "nvarchar (30)", nullable: false),
                    OrderNumber = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersViewModelOrders", x => new { x.CustomersCustomerName, x.OrderNumber });
                    table.ForeignKey(
                        name: "FK_CustomersViewModelOrders_Customers_CustomersCustomerName",
                        column: x => x.CustomersCustomerName,
                        principalTable: "Customers",
                        principalColumn: "CustomerName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersViewModelOrders_Orders_OrderNumber",
                        column: x => x.OrderNumber,
                        principalTable: "Orders",
                        principalColumn: "OrderNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagesOrders",
                columns: table => new
                {
                    ImageItemNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    OrdersOrderNumber = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesOrders", x => new { x.ImageItemNumber, x.OrdersOrderNumber });
                    table.ForeignKey(
                        name: "FK_ImagesOrders_Images_ImageItemNumber",
                        column: x => x.ImageItemNumber,
                        principalTable: "Images",
                        principalColumn: "ItemNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImagesOrders_Orders_OrdersOrderNumber",
                        column: x => x.OrdersOrderNumber,
                        principalTable: "Orders",
                        principalColumn: "OrderNumber",
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
                name: "IX_Customers_CustomersViewModelCustomerName",
                table: "Customers",
                column: "CustomersViewModelCustomerName");

            migrationBuilder.CreateIndex(
                name: "PhoneNumber",
                table: "Customers",
                column: "PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "PostCode",
                table: "Customers",
                column: "PostCode");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersViewModelOrders_OrderNumber",
                table: "CustomersViewModelOrders",
                column: "OrderNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesOrders_OrdersOrderNumber",
                table: "ImagesOrders",
                column: "OrdersOrderNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersViewModelOrders");

            migrationBuilder.DropTable(
                name: "ImagesOrders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
