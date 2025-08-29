using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solv_Assignment_EF_2.Migrations
{
    /// <inheritdoc />
    public partial class ReInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_Courses_Course_ID",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_Instructors_inst_ID",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_Courses_Course_ID",
                table: "StudCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_Students_Stud_ID",
                table: "StudCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topics",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_Name",
                table: "Topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                table: "Students");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Student_Age",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudCourses",
                table: "StudCourses");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Stud_Course_Grade",
                table: "StudCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructors");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Instructor_HourRateBouns",
                table: "Instructors");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Instructor_Salary",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Name",
                table: "Departments");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Department_HiringDate",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Name",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicID",
                table: "Courses");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Course_Duration",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseInstructors",
                table: "CourseInstructors");

            migrationBuilder.DropCheckConstraint(
                name: "CK_CourseInst_Evaluate",
                table: "CourseInstructors");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "TopicID",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Topics",
                newName: "Topic");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "StudCourses",
                newName: "Stud_Course");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "CourseInstructors",
                newName: "Course_Inst");

            migrationBuilder.RenameIndex(
                name: "IX_StudCourses_Course_ID",
                table: "Stud_Course",
                newName: "IX_Stud_Course_Course_ID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseInstructors_Course_ID",
                table: "Course_Inst",
                newName: "IX_Course_Inst_Course_ID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topic",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Student",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Grade",
                table: "Stud_Course",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "HourRateBouns",
                table: "Instructor",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructor",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Course",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Course",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Evaluate",
                table: "Course_Inst",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                table: "Topic",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "Stud_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "inst_ID", "Course_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Dep_Id",
                table: "Student",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Ins_ID",
                table: "Department",
                column: "Ins_ID",
                unique: true,
                filter: "[Ins_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Top_ID",
                table: "Course",
                column: "Top_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Topic_Top_ID",
                table: "Course",
                column: "Top_ID",
                principalTable: "Topic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Course_Course_ID",
                table: "Course_Inst",
                column: "Course_ID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructor_inst_ID",
                table: "Course_Inst",
                column: "inst_ID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department",
                column: "Ins_ID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor",
                column: "Dept_ID",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_Course_ID",
                table: "Stud_Course",
                column: "Course_ID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_Stud_ID",
                table: "Stud_Course",
                column: "Stud_ID",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student",
                column: "Dep_Id",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topic_Top_ID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Course_Course_ID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructor_inst_ID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_Course_ID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_Stud_ID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Dep_Id",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_Ins_ID",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_Top_ID",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Topic",
                newName: "Topics");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                newName: "StudCourses");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Course_Inst",
                newName: "CourseInstructors");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Course_Course_ID",
                table: "StudCourses",
                newName: "IX_StudCourses_Course_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Inst_Course_ID",
                table: "CourseInstructors",
                newName: "IX_CourseInstructors_Course_ID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topics",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "StudCourses",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<decimal>(
                name: "HourRateBouns",
                table: "Instructors",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Evaluate",
                table: "CourseInstructors",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<int>(
                name: "TopicID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topics",
                table: "Topics",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudCourses",
                table: "StudCourses",
                columns: new[] { "Stud_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseInstructors",
                table: "CourseInstructors",
                columns: new[] { "inst_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_Name",
                table: "Topics",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Student_Age",
                table: "Students",
                sql: "[Age] >= 18");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Stud_Course_Grade",
                table: "StudCourses",
                sql: "[Grade] BETWEEN 0 AND 100");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructors",
                column: "DepartmentId");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Instructor_HourRateBouns",
                table: "Instructors",
                sql: "[HourRateBouns] >= 0");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Instructor_Salary",
                table: "Instructors",
                sql: "[Salary] > 0");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Name",
                table: "Departments",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Department_HiringDate",
                table: "Departments",
                sql: "[HiringDate] <= GETDATE()");

            migrationBuilder.AddCheckConstraint(
                name: "CK_CourseInst_Evaluate",
                table: "CourseInstructors",
                sql: "[Evaluate] BETWEEN 1 AND 10");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Name",
                table: "Courses",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicID",
                table: "Courses",
                column: "TopicID");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Course_Duration",
                table: "Courses",
                sql: "[Duration] > 0");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_Courses_Course_ID",
                table: "CourseInstructors",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_Instructors_inst_ID",
                table: "CourseInstructors",
                column: "inst_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses",
                column: "TopicID",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_Courses_Course_ID",
                table: "StudCourses",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_Students_Stud_ID",
                table: "StudCourses",
                column: "Stud_ID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
