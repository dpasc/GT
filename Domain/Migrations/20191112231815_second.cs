using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityAttractions_Cities_CityId",
                table: "CityAttractions");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTravelPackages_People_CustomerId",
                table: "CustomerTravelPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTravelPackages_TravelPackages_TravelPackageId",
                table: "CustomerTravelPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTravelPackages_Vouchers_VoucherId",
                table: "CustomerTravelPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_CustomerTravelPackages_CustomerTravelPackageCustomerId_CustomerTravelPackageTravelPackageId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_People_TravelProviders_TravelProviderId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelPackageCities_Cities_CityId",
                table: "TravelPackageCities");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelPackageCities_TravelPackages_TravelPackageId",
                table: "TravelPackageCities");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelPackageCityAttractions_CityAttractions_CityAttractionId",
                table: "TravelPackageCityAttractions");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelPackageCityAttractions_TravelPackageCities_TravelPackageCityId",
                table: "TravelPackageCityAttractions");

            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_People_CustomerId",
                table: "Vouchers");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TravelPackageCityAttractions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_CityAttractions_Cities_CityId",
                table: "CityAttractions",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTravelPackages_People_CustomerId",
                table: "CustomerTravelPackages",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTravelPackages_TravelPackages_TravelPackageId",
                table: "CustomerTravelPackages",
                column: "TravelPackageId",
                principalTable: "TravelPackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTravelPackages_Vouchers_VoucherId",
                table: "CustomerTravelPackages",
                column: "VoucherId",
                principalTable: "Vouchers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_CustomerTravelPackages_CustomerTravelPackageCustomerId_CustomerTravelPackageTravelPackageId",
                table: "Payments",
                columns: new[] { "CustomerTravelPackageCustomerId", "CustomerTravelPackageTravelPackageId" },
                principalTable: "CustomerTravelPackages",
                principalColumns: new[] { "CustomerId", "TravelPackageId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_TravelProviders_TravelProviderId",
                table: "People",
                column: "TravelProviderId",
                principalTable: "TravelProviders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelPackageCities_Cities_CityId",
                table: "TravelPackageCities",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelPackageCities_TravelPackages_TravelPackageId",
                table: "TravelPackageCities",
                column: "TravelPackageId",
                principalTable: "TravelPackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelPackageCityAttractions_CityAttractions_CityAttractionId",
                table: "TravelPackageCityAttractions",
                column: "CityAttractionId",
                principalTable: "CityAttractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelPackageCityAttractions_TravelPackageCities_TravelPackageCityId",
                table: "TravelPackageCityAttractions",
                column: "TravelPackageCityId",
                principalTable: "TravelPackageCities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_People_CustomerId",
                table: "Vouchers",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityAttractions_Cities_CityId",
                table: "CityAttractions");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTravelPackages_People_CustomerId",
                table: "CustomerTravelPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTravelPackages_TravelPackages_TravelPackageId",
                table: "CustomerTravelPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTravelPackages_Vouchers_VoucherId",
                table: "CustomerTravelPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_CustomerTravelPackages_CustomerTravelPackageCustomerId_CustomerTravelPackageTravelPackageId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_People_TravelProviders_TravelProviderId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelPackageCities_Cities_CityId",
                table: "TravelPackageCities");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelPackageCities_TravelPackages_TravelPackageId",
                table: "TravelPackageCities");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelPackageCityAttractions_CityAttractions_CityAttractionId",
                table: "TravelPackageCityAttractions");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelPackageCityAttractions_TravelPackageCities_TravelPackageCityId",
                table: "TravelPackageCityAttractions");

            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_People_CustomerId",
                table: "Vouchers");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TravelPackageCityAttractions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_CityAttractions_Cities_CityId",
                table: "CityAttractions",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTravelPackages_People_CustomerId",
                table: "CustomerTravelPackages",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTravelPackages_TravelPackages_TravelPackageId",
                table: "CustomerTravelPackages",
                column: "TravelPackageId",
                principalTable: "TravelPackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTravelPackages_Vouchers_VoucherId",
                table: "CustomerTravelPackages",
                column: "VoucherId",
                principalTable: "Vouchers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_CustomerTravelPackages_CustomerTravelPackageCustomerId_CustomerTravelPackageTravelPackageId",
                table: "Payments",
                columns: new[] { "CustomerTravelPackageCustomerId", "CustomerTravelPackageTravelPackageId" },
                principalTable: "CustomerTravelPackages",
                principalColumns: new[] { "CustomerId", "TravelPackageId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_TravelProviders_TravelProviderId",
                table: "People",
                column: "TravelProviderId",
                principalTable: "TravelProviders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelPackageCities_Cities_CityId",
                table: "TravelPackageCities",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelPackageCities_TravelPackages_TravelPackageId",
                table: "TravelPackageCities",
                column: "TravelPackageId",
                principalTable: "TravelPackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelPackageCityAttractions_CityAttractions_CityAttractionId",
                table: "TravelPackageCityAttractions",
                column: "CityAttractionId",
                principalTable: "CityAttractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelPackageCityAttractions_TravelPackageCities_TravelPackageCityId",
                table: "TravelPackageCityAttractions",
                column: "TravelPackageCityId",
                principalTable: "TravelPackageCities",
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
