using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Data.Migrations
{
    public partial class adddescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Properties",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 1", new DateTimeOffset(new DateTime(2019, 7, 20, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(7556), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 2", new DateTimeOffset(new DateTime(2019, 7, 19, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9148), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 3", new DateTimeOffset(new DateTime(2019, 7, 18, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9167), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 4", new DateTimeOffset(new DateTime(2019, 7, 17, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 5", new DateTimeOffset(new DateTime(2019, 7, 16, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9179), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 6", new DateTimeOffset(new DateTime(2019, 7, 15, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9193), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 7", new DateTimeOffset(new DateTime(2019, 7, 14, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9199), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 8", new DateTimeOffset(new DateTime(2019, 7, 13, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9204), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 9", new DateTimeOffset(new DateTime(2019, 7, 12, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9210), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 10", new DateTimeOffset(new DateTime(2019, 7, 11, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9218), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 11", new DateTimeOffset(new DateTime(2019, 7, 10, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9225), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 12", new DateTimeOffset(new DateTime(2019, 7, 9, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 13", new DateTimeOffset(new DateTime(2019, 7, 8, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9525), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 14", new DateTimeOffset(new DateTime(2019, 7, 7, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9535), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 15", new DateTimeOffset(new DateTime(2019, 7, 6, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9540), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 16", new DateTimeOffset(new DateTime(2019, 7, 5, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9545), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 17", new DateTimeOffset(new DateTime(2019, 7, 4, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9550), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 18", new DateTimeOffset(new DateTime(2019, 7, 3, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9556), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 19", new DateTimeOffset(new DateTime(2019, 7, 2, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 20", new DateTimeOffset(new DateTime(2019, 7, 1, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9567), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 21", new DateTimeOffset(new DateTime(2019, 6, 30, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9571), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 22", new DateTimeOffset(new DateTime(2019, 6, 29, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 23", new DateTimeOffset(new DateTime(2019, 6, 28, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9580), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 24", new DateTimeOffset(new DateTime(2019, 6, 27, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9584), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 25", new DateTimeOffset(new DateTime(2019, 6, 26, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9588), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 26", new DateTimeOffset(new DateTime(2019, 6, 25, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9592), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 27", new DateTimeOffset(new DateTime(2019, 6, 24, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 28", new DateTimeOffset(new DateTime(2019, 6, 23, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9600), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 29", new DateTimeOffset(new DateTime(2019, 6, 22, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9604), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 30", new DateTimeOffset(new DateTime(2019, 6, 21, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9608), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 31", new DateTimeOffset(new DateTime(2019, 6, 20, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 32", new DateTimeOffset(new DateTime(2019, 6, 19, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9618), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 33", new DateTimeOffset(new DateTime(2019, 6, 18, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9622), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 34", new DateTimeOffset(new DateTime(2019, 6, 17, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 35", new DateTimeOffset(new DateTime(2019, 6, 16, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 36", new DateTimeOffset(new DateTime(2019, 6, 15, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 37", new DateTimeOffset(new DateTime(2019, 6, 14, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9728), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 38", new DateTimeOffset(new DateTime(2019, 6, 13, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9732), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 39", new DateTimeOffset(new DateTime(2019, 6, 12, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9736), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 40", new DateTimeOffset(new DateTime(2019, 6, 11, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 41", new DateTimeOffset(new DateTime(2019, 6, 10, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 42", new DateTimeOffset(new DateTime(2019, 6, 9, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 43", new DateTimeOffset(new DateTime(2019, 6, 8, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 44", new DateTimeOffset(new DateTime(2019, 6, 7, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 45", new DateTimeOffset(new DateTime(2019, 6, 6, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9765), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 46", new DateTimeOffset(new DateTime(2019, 6, 5, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9770), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 47", new DateTimeOffset(new DateTime(2019, 6, 4, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9776), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 48", new DateTimeOffset(new DateTime(2019, 6, 3, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9780), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 49", new DateTimeOffset(new DateTime(2019, 6, 2, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9784), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 50", new DateTimeOffset(new DateTime(2019, 6, 1, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9790), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 51", new DateTimeOffset(new DateTime(2019, 5, 31, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9796), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 52", new DateTimeOffset(new DateTime(2019, 5, 30, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9801), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 53", new DateTimeOffset(new DateTime(2019, 5, 29, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 54", new DateTimeOffset(new DateTime(2019, 5, 28, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9812), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 55", new DateTimeOffset(new DateTime(2019, 5, 27, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9816), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 56", new DateTimeOffset(new DateTime(2019, 5, 26, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 57", new DateTimeOffset(new DateTime(2019, 5, 25, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 58", new DateTimeOffset(new DateTime(2019, 5, 24, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9909), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 59", new DateTimeOffset(new DateTime(2019, 5, 23, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 60", new DateTimeOffset(new DateTime(2019, 5, 22, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9919), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 61", new DateTimeOffset(new DateTime(2019, 5, 21, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9923), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 62", new DateTimeOffset(new DateTime(2019, 5, 20, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9928), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 63", new DateTimeOffset(new DateTime(2019, 5, 19, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9932), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 64", new DateTimeOffset(new DateTime(2019, 5, 18, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9937), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 65", new DateTimeOffset(new DateTime(2019, 5, 17, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9941), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 66", new DateTimeOffset(new DateTime(2019, 5, 16, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9949), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 67", new DateTimeOffset(new DateTime(2019, 5, 15, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 68", new DateTimeOffset(new DateTime(2019, 5, 14, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 69", new DateTimeOffset(new DateTime(2019, 5, 13, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 70", new DateTimeOffset(new DateTime(2019, 5, 12, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9977), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 71", new DateTimeOffset(new DateTime(2019, 5, 11, 12, 50, 35, 103, DateTimeKind.Unspecified).AddTicks(9985), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 72", new DateTimeOffset(new DateTime(2019, 5, 10, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 73", new DateTimeOffset(new DateTime(2019, 5, 9, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 74", new DateTimeOffset(new DateTime(2019, 5, 8, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(274), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 75", new DateTimeOffset(new DateTime(2019, 5, 7, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(278), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 76", new DateTimeOffset(new DateTime(2019, 5, 6, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(282), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 77", new DateTimeOffset(new DateTime(2019, 5, 5, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 78", new DateTimeOffset(new DateTime(2019, 5, 4, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 79", new DateTimeOffset(new DateTime(2019, 5, 3, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(487), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 80", new DateTimeOffset(new DateTime(2019, 5, 2, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(496), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 81", new DateTimeOffset(new DateTime(2019, 5, 1, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(504), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 82", new DateTimeOffset(new DateTime(2019, 4, 30, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(512), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 83", new DateTimeOffset(new DateTime(2019, 4, 29, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(521), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 84", new DateTimeOffset(new DateTime(2019, 4, 28, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(529), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 85", new DateTimeOffset(new DateTime(2019, 4, 27, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(537), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 86", new DateTimeOffset(new DateTime(2019, 4, 26, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(546), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 87", new DateTimeOffset(new DateTime(2019, 4, 25, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(555), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 88", new DateTimeOffset(new DateTime(2019, 4, 24, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(563), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 89", new DateTimeOffset(new DateTime(2019, 4, 23, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(573), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 90", new DateTimeOffset(new DateTime(2019, 4, 22, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 91", new DateTimeOffset(new DateTime(2019, 4, 21, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(591), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 92", new DateTimeOffset(new DateTime(2019, 4, 20, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(701), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 93", new DateTimeOffset(new DateTime(2019, 4, 19, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(715), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 94", new DateTimeOffset(new DateTime(2019, 4, 18, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 95", new DateTimeOffset(new DateTime(2019, 4, 17, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(725), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 96", new DateTimeOffset(new DateTime(2019, 4, 16, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(729), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 97", new DateTimeOffset(new DateTime(2019, 4, 15, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(738), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 98", new DateTimeOffset(new DateTime(2019, 4, 14, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "LastUpdatedUtc" },
                values: new object[] { "This is a beautiful property. Look at its ID of 99", new DateTimeOffset(new DateTime(2019, 4, 13, 12, 50, 35, 104, DateTimeKind.Unspecified).AddTicks(754), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Properties");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 18, 13, 57, 53, 279, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 17, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1351), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 16, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1360), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 15, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1362), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 14, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1363), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 13, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1367), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 12, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1368), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 11, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1369), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 10, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1371), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 9, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1373), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 8, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1374), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 7, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1375), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 6, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1376), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 5, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1378), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 4, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 3, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 2, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1381), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 7, 1, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1484), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 19,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 30, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1486), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 29, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1487), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 28, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1489), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 27, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 23,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 26, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1491), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 24,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 25, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 25,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 24, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 26,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 23, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 27,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 22, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1495), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 28,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 21, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 29,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 20, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1498), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 30,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 19, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 31,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 18, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1500), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 17, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1501), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 33,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 16, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1502), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 34,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 15, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1504), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 14, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 13, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 37,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 12, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 11, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1509), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 39,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 10, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1510), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 40,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 9, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 41,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 8, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1512), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 42,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 7, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1513), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 43,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 6, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 44,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 5, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 45,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 4, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1516), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 46,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 3, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1518), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 47,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 2, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1519), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 48,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 6, 1, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1520), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 49,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 31, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1521), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 50,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 30, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1522), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 51,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 29, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1523), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 52,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 28, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 53,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 27, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1525), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 54,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 26, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 55,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 25, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1528), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 56,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 24, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1529), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 57,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 23, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 58,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 22, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1531), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 59,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 21, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1532), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 60,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 20, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1533), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 61,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 19, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1534), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 62,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 18, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 63,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 17, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1536), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 64,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 16, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1537), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 65,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 15, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1539), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 66,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 14, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 67,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 13, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1579), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 68,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 12, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 69,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 11, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 70,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 10, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1582), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 71,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 9, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 72,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 8, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 73,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 7, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1585), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 74,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 6, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 75,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 5, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 76,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 4, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 77,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 3, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 78,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 2, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1591), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 79,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 5, 1, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 80,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 30, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1593), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 81,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 29, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 82,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 28, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1595), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 83,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 27, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 84,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 26, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 85,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 25, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 86,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 24, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1599), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 87,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 23, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 88,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 22, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 89,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 21, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 90,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 20, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 91,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 19, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 92,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 18, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1606), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 93,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 17, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 94,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 16, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 95,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 15, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1609), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 96,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 14, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1610), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 97,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 13, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 98,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 12, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1612), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 99,
                column: "LastUpdatedUtc",
                value: new DateTimeOffset(new DateTime(2019, 4, 11, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1614), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
