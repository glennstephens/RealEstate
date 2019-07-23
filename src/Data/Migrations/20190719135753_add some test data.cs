using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Data.Migrations
{
    public partial class addsometestdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    NumberOfBathrooms = table.Column<int>(nullable: false),
                    NumberOfBedrooms = table.Column<int>(nullable: false),
                    LastUpdatedUtc = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "LastUpdatedUtc", "Name", "NumberOfBathrooms", "NumberOfBedrooms", "Price" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2019, 7, 18, 13, 57, 53, 279, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 0, 0, 0, 0)), "Property 1", 1, 2, 10000f },
                    { 72, new DateTimeOffset(new DateTime(2019, 5, 8, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, 0, 0, 0, 0)), "Property 72", 72, 73, 720000f },
                    { 71, new DateTimeOffset(new DateTime(2019, 5, 9, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 0, 0, 0, 0)), "Property 71", 71, 72, 710000f },
                    { 70, new DateTimeOffset(new DateTime(2019, 5, 10, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1582), new TimeSpan(0, 0, 0, 0, 0)), "Property 70", 70, 71, 700000f },
                    { 69, new DateTimeOffset(new DateTime(2019, 5, 11, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 0, 0, 0, 0)), "Property 69", 69, 70, 690000f },
                    { 68, new DateTimeOffset(new DateTime(2019, 5, 12, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 0, 0, 0, 0)), "Property 68", 68, 69, 680000f },
                    { 67, new DateTimeOffset(new DateTime(2019, 5, 13, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1579), new TimeSpan(0, 0, 0, 0, 0)), "Property 67", 67, 68, 670000f },
                    { 66, new DateTimeOffset(new DateTime(2019, 5, 14, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, 0, 0, 0, 0)), "Property 66", 66, 67, 660000f },
                    { 65, new DateTimeOffset(new DateTime(2019, 5, 15, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1539), new TimeSpan(0, 0, 0, 0, 0)), "Property 65", 65, 66, 650000f },
                    { 64, new DateTimeOffset(new DateTime(2019, 5, 16, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1537), new TimeSpan(0, 0, 0, 0, 0)), "Property 64", 64, 65, 640000f },
                    { 63, new DateTimeOffset(new DateTime(2019, 5, 17, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1536), new TimeSpan(0, 0, 0, 0, 0)), "Property 63", 63, 64, 630000f },
                    { 62, new DateTimeOffset(new DateTime(2019, 5, 18, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 0, 0, 0, 0)), "Property 62", 62, 63, 620000f },
                    { 61, new DateTimeOffset(new DateTime(2019, 5, 19, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1534), new TimeSpan(0, 0, 0, 0, 0)), "Property 61", 61, 62, 610000f },
                    { 60, new DateTimeOffset(new DateTime(2019, 5, 20, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1533), new TimeSpan(0, 0, 0, 0, 0)), "Property 60", 60, 61, 600000f },
                    { 59, new DateTimeOffset(new DateTime(2019, 5, 21, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1532), new TimeSpan(0, 0, 0, 0, 0)), "Property 59", 59, 60, 590000f },
                    { 58, new DateTimeOffset(new DateTime(2019, 5, 22, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1531), new TimeSpan(0, 0, 0, 0, 0)), "Property 58", 58, 59, 580000f },
                    { 57, new DateTimeOffset(new DateTime(2019, 5, 23, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 0, 0, 0, 0)), "Property 57", 57, 58, 570000f },
                    { 56, new DateTimeOffset(new DateTime(2019, 5, 24, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1529), new TimeSpan(0, 0, 0, 0, 0)), "Property 56", 56, 57, 560000f },
                    { 55, new DateTimeOffset(new DateTime(2019, 5, 25, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1528), new TimeSpan(0, 0, 0, 0, 0)), "Property 55", 55, 56, 550000f },
                    { 54, new DateTimeOffset(new DateTime(2019, 5, 26, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 0, 0, 0, 0)), "Property 54", 54, 55, 540000f },
                    { 53, new DateTimeOffset(new DateTime(2019, 5, 27, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1525), new TimeSpan(0, 0, 0, 0, 0)), "Property 53", 53, 54, 530000f },
                    { 52, new DateTimeOffset(new DateTime(2019, 5, 28, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 0, 0, 0, 0)), "Property 52", 52, 53, 520000f },
                    { 73, new DateTimeOffset(new DateTime(2019, 5, 7, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1585), new TimeSpan(0, 0, 0, 0, 0)), "Property 73", 73, 74, 730000f },
                    { 51, new DateTimeOffset(new DateTime(2019, 5, 29, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1523), new TimeSpan(0, 0, 0, 0, 0)), "Property 51", 51, 52, 510000f },
                    { 74, new DateTimeOffset(new DateTime(2019, 5, 6, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1586), new TimeSpan(0, 0, 0, 0, 0)), "Property 74", 74, 75, 740000f },
                    { 76, new DateTimeOffset(new DateTime(2019, 5, 4, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1589), new TimeSpan(0, 0, 0, 0, 0)), "Property 76", 76, 77, 760000f },
                    { 97, new DateTimeOffset(new DateTime(2019, 4, 13, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, 0, 0, 0, 0)), "Property 97", 97, 98, 970000f },
                    { 96, new DateTimeOffset(new DateTime(2019, 4, 14, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1610), new TimeSpan(0, 0, 0, 0, 0)), "Property 96", 96, 97, 960000f },
                    { 95, new DateTimeOffset(new DateTime(2019, 4, 15, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1609), new TimeSpan(0, 0, 0, 0, 0)), "Property 95", 95, 96, 950000f },
                    { 94, new DateTimeOffset(new DateTime(2019, 4, 16, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), "Property 94", 94, 95, 940000f },
                    { 93, new DateTimeOffset(new DateTime(2019, 4, 17, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, 0, 0, 0, 0)), "Property 93", 93, 94, 930000f },
                    { 92, new DateTimeOffset(new DateTime(2019, 4, 18, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1606), new TimeSpan(0, 0, 0, 0, 0)), "Property 92", 92, 93, 920000f },
                    { 91, new DateTimeOffset(new DateTime(2019, 4, 19, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 0, 0, 0, 0)), "Property 91", 91, 92, 910000f },
                    { 90, new DateTimeOffset(new DateTime(2019, 4, 20, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1604), new TimeSpan(0, 0, 0, 0, 0)), "Property 90", 90, 91, 900000f },
                    { 89, new DateTimeOffset(new DateTime(2019, 4, 21, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 0, 0, 0, 0)), "Property 89", 89, 90, 890000f },
                    { 88, new DateTimeOffset(new DateTime(2019, 4, 22, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, 0, 0, 0, 0)), "Property 88", 88, 89, 880000f },
                    { 87, new DateTimeOffset(new DateTime(2019, 4, 23, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 0, 0, 0, 0)), "Property 87", 87, 88, 870000f },
                    { 86, new DateTimeOffset(new DateTime(2019, 4, 24, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1599), new TimeSpan(0, 0, 0, 0, 0)), "Property 86", 86, 87, 860000f },
                    { 85, new DateTimeOffset(new DateTime(2019, 4, 25, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)), "Property 85", 85, 86, 850000f },
                    { 84, new DateTimeOffset(new DateTime(2019, 4, 26, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1597), new TimeSpan(0, 0, 0, 0, 0)), "Property 84", 84, 85, 840000f },
                    { 83, new DateTimeOffset(new DateTime(2019, 4, 27, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 0, 0, 0, 0)), "Property 83", 83, 84, 830000f },
                    { 82, new DateTimeOffset(new DateTime(2019, 4, 28, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1595), new TimeSpan(0, 0, 0, 0, 0)), "Property 82", 82, 83, 820000f },
                    { 81, new DateTimeOffset(new DateTime(2019, 4, 29, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1594), new TimeSpan(0, 0, 0, 0, 0)), "Property 81", 81, 82, 810000f },
                    { 80, new DateTimeOffset(new DateTime(2019, 4, 30, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1593), new TimeSpan(0, 0, 0, 0, 0)), "Property 80", 80, 81, 800000f },
                    { 79, new DateTimeOffset(new DateTime(2019, 5, 1, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 0, 0, 0, 0)), "Property 79", 79, 80, 790000f },
                    { 78, new DateTimeOffset(new DateTime(2019, 5, 2, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1591), new TimeSpan(0, 0, 0, 0, 0)), "Property 78", 78, 79, 780000f },
                    { 77, new DateTimeOffset(new DateTime(2019, 5, 3, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 0, 0, 0, 0)), "Property 77", 77, 78, 770000f },
                    { 75, new DateTimeOffset(new DateTime(2019, 5, 5, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 0, 0, 0, 0)), "Property 75", 75, 76, 750000f },
                    { 98, new DateTimeOffset(new DateTime(2019, 4, 12, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1612), new TimeSpan(0, 0, 0, 0, 0)), "Property 98", 98, 99, 980000f },
                    { 50, new DateTimeOffset(new DateTime(2019, 5, 30, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1522), new TimeSpan(0, 0, 0, 0, 0)), "Property 50", 50, 51, 500000f },
                    { 48, new DateTimeOffset(new DateTime(2019, 6, 1, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1520), new TimeSpan(0, 0, 0, 0, 0)), "Property 48", 48, 49, 480000f },
                    { 22, new DateTimeOffset(new DateTime(2019, 6, 27, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 0, 0, 0, 0)), "Property 22", 22, 23, 220000f },
                    { 21, new DateTimeOffset(new DateTime(2019, 6, 28, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1489), new TimeSpan(0, 0, 0, 0, 0)), "Property 21", 21, 22, 210000f },
                    { 20, new DateTimeOffset(new DateTime(2019, 6, 29, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1487), new TimeSpan(0, 0, 0, 0, 0)), "Property 20", 20, 21, 200000f },
                    { 19, new DateTimeOffset(new DateTime(2019, 6, 30, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1486), new TimeSpan(0, 0, 0, 0, 0)), "Property 19", 19, 20, 190000f },
                    { 18, new DateTimeOffset(new DateTime(2019, 7, 1, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1484), new TimeSpan(0, 0, 0, 0, 0)), "Property 18", 18, 19, 180000f },
                    { 17, new DateTimeOffset(new DateTime(2019, 7, 2, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1381), new TimeSpan(0, 0, 0, 0, 0)), "Property 17", 17, 18, 170000f },
                    { 16, new DateTimeOffset(new DateTime(2019, 7, 3, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 0, 0, 0, 0)), "Property 16", 16, 17, 160000f },
                    { 15, new DateTimeOffset(new DateTime(2019, 7, 4, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 0, 0, 0, 0)), "Property 15", 15, 16, 150000f },
                    { 14, new DateTimeOffset(new DateTime(2019, 7, 5, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1378), new TimeSpan(0, 0, 0, 0, 0)), "Property 14", 14, 15, 140000f },
                    { 13, new DateTimeOffset(new DateTime(2019, 7, 6, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1376), new TimeSpan(0, 0, 0, 0, 0)), "Property 13", 13, 14, 130000f },
                    { 12, new DateTimeOffset(new DateTime(2019, 7, 7, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1375), new TimeSpan(0, 0, 0, 0, 0)), "Property 12", 12, 13, 120000f },
                    { 11, new DateTimeOffset(new DateTime(2019, 7, 8, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1374), new TimeSpan(0, 0, 0, 0, 0)), "Property 11", 11, 12, 110000f },
                    { 10, new DateTimeOffset(new DateTime(2019, 7, 9, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1373), new TimeSpan(0, 0, 0, 0, 0)), "Property 10", 10, 11, 100000f },
                    { 9, new DateTimeOffset(new DateTime(2019, 7, 10, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1371), new TimeSpan(0, 0, 0, 0, 0)), "Property 9", 9, 10, 90000f },
                    { 8, new DateTimeOffset(new DateTime(2019, 7, 11, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1369), new TimeSpan(0, 0, 0, 0, 0)), "Property 8", 8, 9, 80000f },
                    { 7, new DateTimeOffset(new DateTime(2019, 7, 12, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1368), new TimeSpan(0, 0, 0, 0, 0)), "Property 7", 7, 8, 70000f },
                    { 6, new DateTimeOffset(new DateTime(2019, 7, 13, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1367), new TimeSpan(0, 0, 0, 0, 0)), "Property 6", 6, 7, 60000f },
                    { 5, new DateTimeOffset(new DateTime(2019, 7, 14, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1363), new TimeSpan(0, 0, 0, 0, 0)), "Property 5", 5, 6, 50000f },
                    { 4, new DateTimeOffset(new DateTime(2019, 7, 15, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1362), new TimeSpan(0, 0, 0, 0, 0)), "Property 4", 4, 5, 40000f },
                    { 3, new DateTimeOffset(new DateTime(2019, 7, 16, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1360), new TimeSpan(0, 0, 0, 0, 0)), "Property 3", 3, 4, 30000f },
                    { 2, new DateTimeOffset(new DateTime(2019, 7, 17, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1351), new TimeSpan(0, 0, 0, 0, 0)), "Property 2", 2, 3, 20000f },
                    { 23, new DateTimeOffset(new DateTime(2019, 6, 26, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1491), new TimeSpan(0, 0, 0, 0, 0)), "Property 23", 23, 24, 230000f },
                    { 49, new DateTimeOffset(new DateTime(2019, 5, 31, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1521), new TimeSpan(0, 0, 0, 0, 0)), "Property 49", 49, 50, 490000f },
                    { 24, new DateTimeOffset(new DateTime(2019, 6, 25, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 0, 0, 0, 0)), "Property 24", 24, 25, 240000f },
                    { 26, new DateTimeOffset(new DateTime(2019, 6, 23, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 0, 0, 0, 0)), "Property 26", 26, 27, 260000f },
                    { 47, new DateTimeOffset(new DateTime(2019, 6, 2, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1519), new TimeSpan(0, 0, 0, 0, 0)), "Property 47", 47, 48, 470000f },
                    { 46, new DateTimeOffset(new DateTime(2019, 6, 3, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1518), new TimeSpan(0, 0, 0, 0, 0)), "Property 46", 46, 47, 460000f },
                    { 45, new DateTimeOffset(new DateTime(2019, 6, 4, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1516), new TimeSpan(0, 0, 0, 0, 0)), "Property 45", 45, 46, 450000f },
                    { 44, new DateTimeOffset(new DateTime(2019, 6, 5, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1515), new TimeSpan(0, 0, 0, 0, 0)), "Property 44", 44, 45, 440000f },
                    { 43, new DateTimeOffset(new DateTime(2019, 6, 6, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 0, 0, 0, 0)), "Property 43", 43, 44, 430000f },
                    { 42, new DateTimeOffset(new DateTime(2019, 6, 7, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1513), new TimeSpan(0, 0, 0, 0, 0)), "Property 42", 42, 43, 420000f },
                    { 41, new DateTimeOffset(new DateTime(2019, 6, 8, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1512), new TimeSpan(0, 0, 0, 0, 0)), "Property 41", 41, 42, 410000f },
                    { 40, new DateTimeOffset(new DateTime(2019, 6, 9, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1511), new TimeSpan(0, 0, 0, 0, 0)), "Property 40", 40, 41, 400000f },
                    { 39, new DateTimeOffset(new DateTime(2019, 6, 10, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1510), new TimeSpan(0, 0, 0, 0, 0)), "Property 39", 39, 40, 390000f },
                    { 38, new DateTimeOffset(new DateTime(2019, 6, 11, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1509), new TimeSpan(0, 0, 0, 0, 0)), "Property 38", 38, 39, 380000f },
                    { 37, new DateTimeOffset(new DateTime(2019, 6, 12, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 0, 0, 0, 0)), "Property 37", 37, 38, 370000f },
                    { 36, new DateTimeOffset(new DateTime(2019, 6, 13, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1506), new TimeSpan(0, 0, 0, 0, 0)), "Property 36", 36, 37, 360000f },
                    { 35, new DateTimeOffset(new DateTime(2019, 6, 14, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 0, 0, 0, 0)), "Property 35", 35, 36, 350000f },
                    { 34, new DateTimeOffset(new DateTime(2019, 6, 15, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1504), new TimeSpan(0, 0, 0, 0, 0)), "Property 34", 34, 35, 340000f },
                    { 33, new DateTimeOffset(new DateTime(2019, 6, 16, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1502), new TimeSpan(0, 0, 0, 0, 0)), "Property 33", 33, 34, 330000f },
                    { 32, new DateTimeOffset(new DateTime(2019, 6, 17, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1501), new TimeSpan(0, 0, 0, 0, 0)), "Property 32", 32, 33, 320000f },
                    { 31, new DateTimeOffset(new DateTime(2019, 6, 18, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1500), new TimeSpan(0, 0, 0, 0, 0)), "Property 31", 31, 32, 310000f },
                    { 30, new DateTimeOffset(new DateTime(2019, 6, 19, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1499), new TimeSpan(0, 0, 0, 0, 0)), "Property 30", 30, 31, 300000f },
                    { 29, new DateTimeOffset(new DateTime(2019, 6, 20, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1498), new TimeSpan(0, 0, 0, 0, 0)), "Property 29", 29, 30, 290000f },
                    { 28, new DateTimeOffset(new DateTime(2019, 6, 21, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 0, 0, 0, 0)), "Property 28", 28, 29, 280000f },
                    { 27, new DateTimeOffset(new DateTime(2019, 6, 22, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1495), new TimeSpan(0, 0, 0, 0, 0)), "Property 27", 27, 28, 270000f },
                    { 25, new DateTimeOffset(new DateTime(2019, 6, 24, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 0, 0, 0, 0)), "Property 25", 25, 26, 250000f },
                    { 99, new DateTimeOffset(new DateTime(2019, 4, 11, 13, 57, 53, 280, DateTimeKind.Unspecified).AddTicks(1614), new TimeSpan(0, 0, 0, 0, 0)), "Property 99", 99, 100, 990000f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
