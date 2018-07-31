using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EN.MvcPractice.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TitleText = table.Column<string>(nullable: true),
                    TitleSize = table.Column<int>(nullable: false),
                    TitleColor = table.Column<int>(nullable: false)
                },
                constraints: table =>
#pragma warning disable RCS1021 // Simplify lambda expression.
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });
#pragma warning restore RCS1021 // Simplify lambda expression.

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "TitleColor", "TitleSize", "TitleText" },
                values: new object[] { 1, -16777216, 18, "Homepage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
