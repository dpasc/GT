using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class removeVouchers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTravelPackages_Vouchers_VoucherId",
                table: "CustomerTravelPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_People_CustomerId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerTravelPackages_VoucherId",
                table: "CustomerTravelPackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vouchers",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "VoucherId",
                table: "CustomerTravelPackages");

            migrationBuilder.RenameTable(
                name: "Vouchers",
                newName: "Voucher");

            migrationBuilder.RenameIndex(
                name: "IX_Vouchers_CustomerId",
                table: "Voucher",
                newName: "IX_Voucher_CustomerId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "Voucher",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "DATEADD(month, 3, GETDATE())");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voucher",
                table: "Voucher",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Voucher_People_CustomerId",
                table: "Voucher",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voucher_People_CustomerId",
                table: "Voucher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voucher",
                table: "Voucher");

            migrationBuilder.RenameTable(
                name: "Voucher",
                newName: "Vouchers");

            migrationBuilder.RenameIndex(
                name: "IX_Voucher_CustomerId",
                table: "Vouchers",
                newName: "IX_Vouchers_CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "VoucherId",
                table: "CustomerTravelPackages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "Vouchers",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "DATEADD(month, 3, GETDATE())",
                oldClrType: typeof(DateTime));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vouchers",
                table: "Vouchers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTravelPackages_VoucherId",
                table: "CustomerTravelPackages",
                column: "VoucherId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTravelPackages_Vouchers_VoucherId",
                table: "CustomerTravelPackages",
                column: "VoucherId",
                principalTable: "Vouchers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_People_CustomerId",
                table: "Vouchers",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
