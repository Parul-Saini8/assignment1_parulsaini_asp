using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImperialRulers.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ruler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    ManufactureDate = table.Column<DateTime>(nullable: false),
                    Types = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Length = table.Column<decimal>(nullable: false),
                    Material = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ruler");
        }
    }
}