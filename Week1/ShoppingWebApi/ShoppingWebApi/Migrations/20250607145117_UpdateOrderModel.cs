using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingWebApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_product_Productid",
                table: "order");

            migrationBuilder.DropIndex(
                name: "IX_order_Productid",
                table: "order");

            migrationBuilder.DropColumn(
                name: "address",
                table: "order");

            migrationBuilder.DropColumn(
                name: "name",
                table: "order");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "order",
                newName: "customer_name");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "order",
                newName: "quantity");

            migrationBuilder.AddColumn<DateTime>(
                name: "order_date",
                table: "order",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "order",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "order_date",
                table: "order");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "order");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "order",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "customer_name",
                table: "order",
                newName: "phone");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "order",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "order",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_order_Productid",
                table: "order",
                column: "Productid");

            migrationBuilder.AddForeignKey(
                name: "FK_order_product_Productid",
                table: "order",
                column: "Productid",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
