using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeindaSaid_EntityFramework_Assinment1.Migrations
{
    public partial class instructorcourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create Departments Table
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HiringDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ins_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            // Create Topics Table
            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            // Create Instructors Table
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deptId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bouns = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 100, nullable: false),
                    Hourrate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_deptId",
                        column: x => x.deptId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            // Create Students Table
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    deptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Departments_deptId",
                        column: x => x.deptId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            // Create Courses Table
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Create Instructor_Courses Table
            migrationBuilder.CreateTable(
                name: "Instructor_Courses",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor_Courses", x => new { x.InstructorId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_Instructor_Courses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructor_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Create Stud_Courses Table
            migrationBuilder.CreateTable(
                name: "Stud_Courses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    grade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Courses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_Stud_Courses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stud_Courses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Create Indexes
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Courses_InstructorId' AND object_id = OBJECT_ID('Courses'))
                BEGIN
                    CREATE INDEX [IX_Courses_InstructorId] ON [Courses] ([InstructorId]);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Courses_TopicId' AND object_id = OBJECT_ID('Courses'))
                BEGIN
                    CREATE INDEX [IX_Courses_TopicId] ON [Courses] ([TopicId]);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Instructor_Courses_CourseId' AND object_id = OBJECT_ID('Instructor_Courses'))
                BEGIN
                    CREATE INDEX [IX_Instructor_Courses_CourseId] ON [Instructor_Courses] ([CourseId]);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Instructors_deptId' AND object_id = OBJECT_ID('Instructors'))
                BEGIN
                    CREATE INDEX [IX_Instructors_deptId] ON [Instructors] ([deptId]);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Stud_Courses_CourseId' AND object_id = OBJECT_ID('Stud_Courses'))
                BEGIN
                    CREATE INDEX [IX_Stud_Courses_CourseId] ON [Stud_Courses] ([CourseId]);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Students_deptId' AND object_id = OBJECT_ID('Students'))
                BEGIN
                    CREATE INDEX [IX_Students_deptId] ON [Students] ([deptId]);
                END
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop Indexes
            migrationBuilder.DropIndex(name: "IX_Students_deptId", table: "Students");
            migrationBuilder.DropIndex(name: "IX_Stud_Courses_CourseId", table: "Stud_Courses");
            migrationBuilder.DropIndex(name: "IX_Instructor_Courses_CourseId", table: "Instructor_Courses");
            migrationBuilder.DropIndex(name: "IX_Instructors_deptId", table: "Instructors");
            migrationBuilder.DropIndex(name: "IX_Courses_TopicId", table: "Courses");
            migrationBuilder.DropIndex(name: "IX_Courses_InstructorId", table: "Courses");

            // Drop Tables
            migrationBuilder.DropTable(name: "Instructor_Courses");
            migrationBuilder.DropTable(name: "Stud_Courses");
            migrationBuilder.DropTable(name: "Courses");
            migrationBuilder.DropTable(name: "Students");
            migrationBuilder.DropTable(name: "Instructors");
            migrationBuilder.DropTable(name: "Topics");
            migrationBuilder.DropTable(name: "Departments");
        }
    }
}
