using Microsoft.EntityFrameworkCore.Migrations;

namespace Piranha.Data.EF.MySql.Migrations
{
    [NoCoverage]
    public partial class AddMediaVersionExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET default_storage_engine=INNODB");

            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "Piranha_MediaVersions",
                maxLength: 8,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "Piranha_MediaVersions");
        }
    }
}
