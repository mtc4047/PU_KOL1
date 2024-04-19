using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Grupy",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupy_ParentId",
                table: "Grupy",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupy_Grupy_ParentId",
                table: "Grupy",
                column: "ParentId",
                principalTable: "Grupy",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupy_Grupy_ParentId",
                table: "Grupy");

            migrationBuilder.DropIndex(
                name: "IX_Grupy_ParentId",
                table: "Grupy");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Grupy");
        }
    }
}
