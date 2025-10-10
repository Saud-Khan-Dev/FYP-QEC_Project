using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QEC_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddedXrefManytoManyRelationsship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "XrefFacultyCourses",
                columns: table => new
                {
                    FacultyId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XrefFacultyCourses", x => new { x.FacultyId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_XrefFacultyCourses_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_XrefFacultyCourses_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_XrefFacultyCourses_CourseId",
                table: "XrefFacultyCourses",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "XrefFacultyCourses");
        }
    }
}
