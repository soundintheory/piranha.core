using Microsoft.EntityFrameworkCore.Migrations;

namespace Piranha.Data.EF.MySql.Migrations
{
    [NoCoverage]
    public partial class AddSiteCulture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET default_storage_engine=INNODB");

            migrationBuilder.AddColumn<string>(
                name: "Culture",
                table: "Piranha_Sites",
                maxLength: 6,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Culture",
                table: "Piranha_Sites");
        }
    }
}
