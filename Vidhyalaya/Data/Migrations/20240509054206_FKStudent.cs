using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidhyalaya.Data.Migrations
{
    /// <inheritdoc />
    public partial class FKStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeLabel",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradeLabel",
                table: "Students",
                column: "GradeLabel");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeLabel",
                table: "Students",
                column: "GradeLabel",
                principalTable: "Grades",
                principalColumn: "Label",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeLabel",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GradeLabel",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GradeLabel",
                table: "Students");
        }
    }
}
