using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingTest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Panel1Title = table.Column<string>(type: "TEXT", nullable: true),
                    Panel1Text = table.Column<string>(type: "TEXT", nullable: true),
                    Panel2Title = table.Column<string>(type: "TEXT", nullable: true),
                    Panel2Text = table.Column<string>(type: "TEXT", nullable: true),
                    Panel3Title = table.Column<string>(type: "TEXT", nullable: true),
                    Panel3ImageTitle1 = table.Column<string>(type: "TEXT", nullable: true),
                    Panel3ImageTitle2 = table.Column<string>(type: "TEXT", nullable: true),
                    Panel3ImageTitle3 = table.Column<string>(type: "TEXT", nullable: true),
                    Panel3ImageText1 = table.Column<string>(type: "TEXT", nullable: true),
                    Panel3ImageText2 = table.Column<string>(type: "TEXT", nullable: true),
                    Panel3ImageText3 = table.Column<string>(type: "TEXT", nullable: true),
                    Panel4Title = table.Column<string>(type: "TEXT", nullable: true),
                    Panel4Text = table.Column<string>(type: "TEXT", nullable: true),
                    Panel1Image = table.Column<string>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elements");
        }
    }
}
