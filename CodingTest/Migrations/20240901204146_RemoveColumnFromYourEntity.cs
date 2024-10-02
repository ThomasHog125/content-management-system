using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingTest.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColumnFromYourEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Panel1Text",
                table: "Elements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Panel1Text",
                table: "Elements",
                type: "TEXT",
                nullable: true);
        }
    }
}
