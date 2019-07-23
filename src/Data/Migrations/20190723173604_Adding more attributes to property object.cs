using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Data.Migrations
{
    public partial class Addingmoreattributestopropertyobject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasAirConditioning",
                table: "Properties",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasBalcony",
                table: "Properties",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasBroadband",
                table: "Properties",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFloorboards",
                table: "Properties",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasRemoteGarage",
                table: "Properties",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 22, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 21, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 20, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 19, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5662), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 18, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5664), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 7, 17, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 16, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5670), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 15, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 14, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5674), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "HasAirConditioning", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 7, 13, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5676), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 12, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5678), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 7, 11, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "HasRemoteGarage", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 10, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5780), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "HasAirConditioning", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 7, 9, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5783), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "HasBalcony", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 7, 8, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 7, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5787), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 6, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5789), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 7, 5, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5792), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 19,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 4, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "HasAirConditioning", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 7, 3, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "HasBalcony", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 7, 2, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5797), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 7, 1, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5798), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 23,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 30, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5800), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 29, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5802), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 28, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5804), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "HasAirConditioning", "HasRemoteGarage", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 27, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5806), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 26, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5808), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "HasAirConditioning", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 25, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5809), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 29,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 24, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5811), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "HasAirConditioning", "HasBalcony", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, true, new DateTimeOffset(new DateTime(2019, 6, 23, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 31,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 22, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5815), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 21, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 20, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5818), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 19, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5856), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "HasBroadband", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 18, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5858), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 17, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5860), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 37,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 16, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5862), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 15, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5863), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "HasBalcony", "HasRemoteGarage", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 14, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5865), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "HasAirConditioning", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 13, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5867), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 41,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 12, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "HasAirConditioning", "HasBalcony", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, true, new DateTimeOffset(new DateTime(2019, 6, 11, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5870), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 43,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 10, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5872), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 9, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5874), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "HasBalcony", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 8, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5875), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 7, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5877), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 47,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 6, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5879), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 5, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 4, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5882), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "HasAirConditioning", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 3, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5884), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 6, 2, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5886), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "HasAirConditioning", "HasRemoteGarage", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 6, 1, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 53,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 31, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5889), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 5, 30, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5891), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 29, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "HasAirConditioning", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 5, 28, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5894), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 27, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5927), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 26, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5929), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 59,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 25, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5930), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "HasAirConditioning", "HasBalcony", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, true, new DateTimeOffset(new DateTime(2019, 5, 24, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5932), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 61,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 23, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5934), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 22, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "HasBalcony", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 5, 21, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5937), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 20, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5939), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "HasBroadband", "HasRemoteGarage", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 5, 19, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5941), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 5, 18, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5943), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 67,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 17, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5945), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 16, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5947), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 15, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5949), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "HasAirConditioning", "HasBroadband", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, true, new DateTimeOffset(new DateTime(2019, 5, 14, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 71,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 13, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 5, 12, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 73,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 11, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5956), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 10, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5957), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "HasBalcony", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 5, 9, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5959), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 8, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5988), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 7, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "HasAirConditioning", "HasBalcony", "HasRemoteGarage", "LastUpdatedUtc" },
                values: new object[] { true, true, true, new DateTimeOffset(new DateTime(2019, 5, 6, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 79,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 5, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5993), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "HasAirConditioning", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 5, 4, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5995), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 3, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5997), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 5, 2, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(5999), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 83,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 1, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6001), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "HasAirConditioning", "HasBalcony", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, true, new DateTimeOffset(new DateTime(2019, 4, 30, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6002), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 4, 29, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6004), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 4, 28, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6006), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 4, 27, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6007), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 4, 26, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6009), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 89,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 25, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "HasAirConditioning", "HasBalcony", "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, true, true, new DateTimeOffset(new DateTime(2019, 4, 24, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6012), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "HasFloorboards", "HasRemoteGarage", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 4, 23, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6014), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 4, 22, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6016), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 4, 21, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6017), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "HasAirConditioning", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 4, 20, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "HasBroadband", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 4, 19, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "HasAirConditioning", "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 4, 18, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 97,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 17, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6024), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "HasAirConditioning", "HasFloorboards", "LastUpdatedUtc" },
                values: new object[] { true, true, new DateTimeOffset(new DateTime(2019, 4, 16, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6026), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "HasBalcony", "LastUpdatedUtc" },
                values: new object[] { true, new DateTimeOffset(new DateTime(2019, 4, 15, 17, 36, 3, 849, DateTimeKind.Unspecified).AddTicks(6054), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasAirConditioning",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "HasBalcony",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "HasBroadband",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "HasFloorboards",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "HasRemoteGarage",
                table: "Properties");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 20, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(7556), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 19, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9148), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 18, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9167), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 17, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 16, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9179), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 15, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9193), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 14, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9199), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 13, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 12, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9210), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 11, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9218), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 10, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9225), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 9, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 8, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9525), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 7, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9535), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 6, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9540), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 5, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9545), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 4, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9550), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 3, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9556), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 19,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 2, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 1, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9567), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 30, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9571), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 29, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9575), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 23,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 28, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9580), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 24,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 27, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9584), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 25,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 26, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9588), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 26,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 25, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9592), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 27,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 24, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9596), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 28,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 23, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 29,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 22, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 30,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 21, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9608), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 31,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 20, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9613), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 19, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9618), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 33,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 18, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9622), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 34,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 17, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 16, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 15, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 37,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 14, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9728), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 13, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9732), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 39,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 12, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9736), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 40,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 11, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 41,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 10, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 42,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 9, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9749), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 43,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 8, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 44,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 7, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 45,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 6, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9765), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 46,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 5, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9770), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 47,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 4, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9776), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 48,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 3, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9780), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 49,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 2, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9784), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 50,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 1, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9790), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 51,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 31, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9796), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 52,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 30, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9801), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 53,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 29, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 54,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 28, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9812), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 55,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 27, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9816), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 56,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 26, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 57,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 25, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 58,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 24, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9909), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 59,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 23, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 60,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 22, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9919), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 61,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 21, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 62,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 20, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 63,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 19, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9932), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 64,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 18, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9937), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 65,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 17, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9941), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 66,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 16, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9949), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 67,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 15, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 68,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 14, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 69,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 13, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 70,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 12, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9977), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 71,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 11, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9985), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 72,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 10, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 73,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 9, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 74,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 8, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(274), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 75,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 7, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(278), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 76,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 6, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(282), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 77,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 5, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 78,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 4, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 79,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 3, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(487), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 80,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 2, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(496), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 81,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 1, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(504), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 82,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 30, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(512), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 83,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 29, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(521), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 84,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 28, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(529), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 85,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 27, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(537), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 86,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 26, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(546), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 87,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 25, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(555), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 88,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 24, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(563), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 89,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 23, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(573), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 90,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 22, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 91,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 21, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(591), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 92,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 20, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(701), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 93,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 19, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(715), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 94,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 18, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 95,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 17, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 96,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 16, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(729), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 97,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 15, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(738), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 98,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 14, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 99,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 13, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(754), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
