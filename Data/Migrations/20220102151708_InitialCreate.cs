using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Customers_CustomersViewModelCustomerName",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "CustomersViewModelOrders");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomersViewModelCustomerName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomersViewModelCustomerName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Images",
                newName: "ItemName");

            migrationBuilder.AddColumn<bool>(
                name: "OrderSuccessful",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<double>(
                name: "ItemPrice",
                table: "Images",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Images",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "STRING",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderSuccessful",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Images",
                newName: "CustomerName");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemPrice",
                table: "Images",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<string>(
                name: "CustomersViewModelCustomerName",
                table: "Customers",
                type: "nvarchar (30)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomersViewModelCustomerName",
                table: "Customers",
                column: "CustomersViewModelCustomerName");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersViewModelOrders_OrderNumber",
                table: "CustomersViewModelOrders",
                column: "OrderNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Customers_CustomersViewModelCustomerName",
                table: "Customers",
                column: "CustomersViewModelCustomerName",
                principalTable: "Customers",
                principalColumn: "CustomerName");
        }
    }
}
