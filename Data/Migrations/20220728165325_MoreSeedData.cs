using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_MovieRandomizer.Data.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSales",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "OpeningWeekendSales", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("00463795-12f5-43cf-8d5f-6625f923b0c0"), 345345345.0, 0, new DateTime(2007, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Rise of Darkrai" },
                    { new Guid("05fcfd45-9640-44e5-a9c8-474771bb0f0d"), 345345345.0, 0, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mewtwo Strikes Back:Evolution" },
                    { new Guid("0b563a12-95fe-4b3b-b064-2b313d9e8fad"), 345345345.0, 0, new DateTime(1999, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon:The Movie 2000" },
                    { new Guid("0f01cf4c-ada8-47bf-851c-54511fcc9452"), 345345345.0, 0, new DateTime(2013, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genesect and the Legend Awakened" },
                    { new Guid("3b4ea11f-d809-4171-85c9-69689bd4590c"), 345345345.0, 0, new DateTime(2009, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arceus and the Jewel of Life" },
                    { new Guid("6da8557d-a8ee-4007-8f3f-589e11774875"), 345345345.0, 0, new DateTime(2000, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon 3: The Movie - Spell of the Unown" },
                    { new Guid("787d31a1-9ef9-4878-a5a7-05bcbead08d4"), 345345345.0, 0, new DateTime(2014, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diancie and the Coccoon of Destruction" },
                    { new Guid("78b7ee83-de99-4c18-bdcd-e51509fba783"), 345345345.0, 0, new DateTime(2003, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jirachi—Wish Maker" },
                    { new Guid("984a54c7-a77e-4170-abbe-93c0f10a4473"), 345345345.0, 0, new DateTime(2015, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoopa and the Clash of Ages" },
                    { new Guid("9b81b94a-b349-416a-bf6a-1e0ee522af0b"), 345345345.0, 0, new DateTime(2012, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyruem vs.the Sword of Justice" },
                    { new Guid("9cf5db30-ee2b-449c-9932-b4a1f416416c"), 345345345.0, 0, new DateTime(2004, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Destiny Deoxys" },
                    { new Guid("ab8c3688-d543-4da2-b99c-c2c8d62f3507"), 345345345.0, 0, new DateTime(2008, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giratina and the Sky Warrior" },
                    { new Guid("c4d62c29-2e5c-44ba-abc2-54ca990f1f89"), 345345345.0, 0, new DateTime(2017, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "I Choose You!" },
                    { new Guid("ce40dcbe-9c39-4705-8d47-731597dfd50e"), 345345345.0, 0, new DateTime(2010, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zoroark--Master of Illusions" },
                    { new Guid("e48c1456-5e27-4304-9bae-b3e18045811d"), 345345345.0, 0, new DateTime(2006, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Ranger and the Temple of the Sea" },
                    { new Guid("e5464945-4a65-4fec-8b66-a945497238df"), 345345345.0, 0, new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secrets of the Jungle" },
                    { new Guid("e7e25a3f-a394-4ab4-90db-dc9842bc8c47"), 345345345.0, 0, new DateTime(2005, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucario and the Mystery of Mew" },
                    { new Guid("e8a299e3-c2e2-43bd-bed6-67535548fcca"), 345345345.0, 0, new DateTime(2018, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Power of Us" },
                    { new Guid("e9a4eba3-da09-40b9-8a2e-f7558a240d23"), 345345345.0, 0, new DateTime(2011, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "White--Victini and Zekrom" },
                    { new Guid("ec4a1ebe-a63f-4f53-afac-f40cef1d6f5b"), 345345345.0, 0, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volcanion and the Mechanical Marvel" },
                    { new Guid("f92ee42d-59c3-49a5-a0ca-54ba1e15fe80"), 345345345.0, 0, new DateTime(2001, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon 4Ever: Celebi - Voice of the Forest" },
                    { new Guid("faf5bb2f-33c6-495c-b179-76a72f119781"), 345345345.0, 0, new DateTime(2002, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Heroes: Latios and Latias" },
                    { new Guid("fe92db7f-1a35-4bca-97ee-de59b25b5111"), 345345345.0, 0, new DateTime(2011, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black--Victini and Reshiram" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00463795-12f5-43cf-8d5f-6625f923b0c0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("05fcfd45-9640-44e5-a9c8-474771bb0f0d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0b563a12-95fe-4b3b-b064-2b313d9e8fad"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0f01cf4c-ada8-47bf-851c-54511fcc9452"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3b4ea11f-d809-4171-85c9-69689bd4590c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6da8557d-a8ee-4007-8f3f-589e11774875"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("787d31a1-9ef9-4878-a5a7-05bcbead08d4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("78b7ee83-de99-4c18-bdcd-e51509fba783"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("984a54c7-a77e-4170-abbe-93c0f10a4473"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9b81b94a-b349-416a-bf6a-1e0ee522af0b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9cf5db30-ee2b-449c-9932-b4a1f416416c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ab8c3688-d543-4da2-b99c-c2c8d62f3507"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c4d62c29-2e5c-44ba-abc2-54ca990f1f89"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ce40dcbe-9c39-4705-8d47-731597dfd50e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e48c1456-5e27-4304-9bae-b3e18045811d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e5464945-4a65-4fec-8b66-a945497238df"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e7e25a3f-a394-4ab4-90db-dc9842bc8c47"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e8a299e3-c2e2-43bd-bed6-67535548fcca"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e9a4eba3-da09-40b9-8a2e-f7558a240d23"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ec4a1ebe-a63f-4f53-afac-f40cef1d6f5b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f92ee42d-59c3-49a5-a0ca-54ba1e15fe80"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("faf5bb2f-33c6-495c-b179-76a72f119781"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fe92db7f-1a35-4bca-97ee-de59b25b5111"));

            migrationBuilder.AddColumn<double>(
                name: "TotalSales",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f11ddda7-bb09-4d47-8da6-26f2065f15c8"),
                column: "TotalSales",
                value: 34534534.0);
        }
    }
}
