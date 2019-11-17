using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_CustomerTravelPackages_CustomerTravelPackageCustomerId_CustomerTravelPackageTravelPackageId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CustomerTravelPackageCustomerId_CustomerTravelPackageTravelPackageId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerTravelPackages",
                table: "CustomerTravelPackages");

            migrationBuilder.DropColumn(
                name: "CustomerTravelPackageCustomerId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CustomerTravelPackageTravelPackageId",
                table: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CustomerTravelPackages",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerTravelPackages",
                table: "CustomerTravelPackages",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerTravelPackageId",
                table: "Payments",
                column: "CustomerTravelPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTravelPackages_CustomerId",
                table: "CustomerTravelPackages",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_CustomerTravelPackages_CustomerTravelPackageId",
                table: "Payments",
                column: "CustomerTravelPackageId",
                principalTable: "CustomerTravelPackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_CustomerTravelPackages_CustomerTravelPackageId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CustomerTravelPackageId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerTravelPackages",
                table: "CustomerTravelPackages");

            migrationBuilder.DropIndex(
                name: "IX_CustomerTravelPackages_CustomerId",
                table: "CustomerTravelPackages");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerTravelPackages");

            migrationBuilder.AddColumn<int>(
                name: "CustomerTravelPackageCustomerId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerTravelPackageTravelPackageId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerTravelPackages",
                table: "CustomerTravelPackages",
                columns: new[] { "CustomerId", "TravelPackageId" });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerTravelPackageCustomerId_CustomerTravelPackageTravelPackageId",
                table: "Payments",
                columns: new[] { "CustomerTravelPackageCustomerId", "CustomerTravelPackageTravelPackageId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_CustomerTravelPackages_CustomerTravelPackageCustomerId_CustomerTravelPackageTravelPackageId",
                table: "Payments",
                columns: new[] { "CustomerTravelPackageCustomerId", "CustomerTravelPackageTravelPackageId" },
                principalTable: "CustomerTravelPackages",
                principalColumns: new[] { "CustomerId", "TravelPackageId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
