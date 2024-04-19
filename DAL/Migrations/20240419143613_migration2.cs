using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductGroups_IdGrupy",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ProductGroups_IdGrupy",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductGroups",
                table: "ProductGroups");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Historia");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Studenci");

            migrationBuilder.RenameTable(
                name: "ProductGroups",
                newName: "Grupy");

            migrationBuilder.RenameIndex(
                name: "IX_Users_IdGrupy",
                table: "Historia",
                newName: "IX_Historia_IdGrupy");

            migrationBuilder.RenameIndex(
                name: "IX_Products_IdGrupy",
                table: "Studenci",
                newName: "IX_Studenci_IdGrupy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Historia",
                table: "Historia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studenci",
                table: "Studenci",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupy",
                table: "Grupy",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Historia_Grupy_IdGrupy",
                table: "Historia",
                column: "IdGrupy",
                principalTable: "Grupy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Studenci_Grupy_IdGrupy",
                table: "Studenci",
                column: "IdGrupy",
                principalTable: "Grupy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historia_Grupy_IdGrupy",
                table: "Historia");

            migrationBuilder.DropForeignKey(
                name: "FK_Studenci_Grupy_IdGrupy",
                table: "Studenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studenci",
                table: "Studenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Historia",
                table: "Historia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupy",
                table: "Grupy");

            migrationBuilder.RenameTable(
                name: "Studenci",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Historia",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Grupy",
                newName: "ProductGroups");

            migrationBuilder.RenameIndex(
                name: "IX_Studenci_IdGrupy",
                table: "Products",
                newName: "IX_Products_IdGrupy");

            migrationBuilder.RenameIndex(
                name: "IX_Historia_IdGrupy",
                table: "Users",
                newName: "IX_Users_IdGrupy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductGroups",
                table: "ProductGroups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductGroups_IdGrupy",
                table: "Products",
                column: "IdGrupy",
                principalTable: "ProductGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ProductGroups_IdGrupy",
                table: "Users",
                column: "IdGrupy",
                principalTable: "ProductGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
