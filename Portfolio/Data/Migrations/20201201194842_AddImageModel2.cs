using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class AddImageModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageModel_Project_projectId",
                table: "ImageModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageModel",
                table: "ImageModel");

            migrationBuilder.RenameTable(
                name: "ImageModel",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "Image",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ImageModel_projectId",
                table: "Image",
                newName: "IX_Image_ProjectId");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Image",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Project_ProjectId",
                table: "Image",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Project_ProjectId",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "ImageModel");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ImageModel",
                newName: "projectId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_ProjectId",
                table: "ImageModel",
                newName: "IX_ImageModel_projectId");

            migrationBuilder.AlterColumn<int>(
                name: "projectId",
                table: "ImageModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageModel",
                table: "ImageModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageModel_Project_projectId",
                table: "ImageModel",
                column: "projectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
