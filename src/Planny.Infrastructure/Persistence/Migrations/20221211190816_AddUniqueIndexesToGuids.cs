using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planny.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueIndexesToGuids : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TodoList_Guid",
                table: "TodoList",
                column: "Guid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoItem_Guid",
                table: "TodoItem",
                column: "Guid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TodoList_Guid",
                table: "TodoList");

            migrationBuilder.DropIndex(
                name: "IX_TodoItem_Guid",
                table: "TodoItem");
        }
    }
}
