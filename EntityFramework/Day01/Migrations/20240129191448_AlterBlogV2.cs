using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day01.Migrations
{
    /// <inheritdoc />
    public partial class AlterBlogV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Blogs",
                newName: "Url");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Blogs",
                newName: "Name");
        }
    }
}
