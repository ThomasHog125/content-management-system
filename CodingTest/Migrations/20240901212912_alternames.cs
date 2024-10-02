using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingTest.Migrations
{
    /// <inheritdoc />
    public partial class alternames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Panel4Title",
                table: "Elements",
                newName: "Panal4Title");

            migrationBuilder.RenameColumn(
                name: "Panel4Text",
                table: "Elements",
                newName: "Panal4Text");

            migrationBuilder.RenameColumn(
                name: "Panel3Title",
                table: "Elements",
                newName: "Panal3Title");

            migrationBuilder.RenameColumn(
                name: "Panel3ImageTitle3",
                table: "Elements",
                newName: "Panal3ImageTitle3");

            migrationBuilder.RenameColumn(
                name: "Panel3ImageTitle2",
                table: "Elements",
                newName: "Panal3ImageTitle2");

            migrationBuilder.RenameColumn(
                name: "Panel3ImageTitle1",
                table: "Elements",
                newName: "Panal3ImageTitle1");

            migrationBuilder.RenameColumn(
                name: "Panel3ImageText3",
                table: "Elements",
                newName: "Panal3ImageText3");

            migrationBuilder.RenameColumn(
                name: "Panel3ImageText2",
                table: "Elements",
                newName: "Panal3ImageText2");

            migrationBuilder.RenameColumn(
                name: "Panel3ImageText1",
                table: "Elements",
                newName: "Panal3ImageText1");

            migrationBuilder.RenameColumn(
                name: "Panel2Title",
                table: "Elements",
                newName: "Panal2Title");

            migrationBuilder.RenameColumn(
                name: "Panel2Text",
                table: "Elements",
                newName: "Panal2Text");

            migrationBuilder.RenameColumn(
                name: "Panel1Title",
                table: "Elements",
                newName: "Panal1Title");

            migrationBuilder.RenameColumn(
                name: "Panel1Image",
                table: "Elements",
                newName: "Panal1Image");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Panal4Title",
                table: "Elements",
                newName: "Panel4Title");

            migrationBuilder.RenameColumn(
                name: "Panal4Text",
                table: "Elements",
                newName: "Panel4Text");

            migrationBuilder.RenameColumn(
                name: "Panal3Title",
                table: "Elements",
                newName: "Panel3Title");

            migrationBuilder.RenameColumn(
                name: "Panal3ImageTitle3",
                table: "Elements",
                newName: "Panel3ImageTitle3");

            migrationBuilder.RenameColumn(
                name: "Panal3ImageTitle2",
                table: "Elements",
                newName: "Panel3ImageTitle2");

            migrationBuilder.RenameColumn(
                name: "Panal3ImageTitle1",
                table: "Elements",
                newName: "Panel3ImageTitle1");

            migrationBuilder.RenameColumn(
                name: "Panal3ImageText3",
                table: "Elements",
                newName: "Panel3ImageText3");

            migrationBuilder.RenameColumn(
                name: "Panal3ImageText2",
                table: "Elements",
                newName: "Panel3ImageText2");

            migrationBuilder.RenameColumn(
                name: "Panal3ImageText1",
                table: "Elements",
                newName: "Panel3ImageText1");

            migrationBuilder.RenameColumn(
                name: "Panal2Title",
                table: "Elements",
                newName: "Panel2Title");

            migrationBuilder.RenameColumn(
                name: "Panal2Text",
                table: "Elements",
                newName: "Panel2Text");

            migrationBuilder.RenameColumn(
                name: "Panal1Title",
                table: "Elements",
                newName: "Panel1Title");

            migrationBuilder.RenameColumn(
                name: "Panal1Image",
                table: "Elements",
                newName: "Panel1Image");
        }
    }
}
