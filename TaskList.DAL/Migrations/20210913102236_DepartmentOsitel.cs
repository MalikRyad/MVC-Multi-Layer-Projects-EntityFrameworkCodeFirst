using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskList.DAL.Migrations
{
    public partial class DepartmentOsitel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentOsitel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedById = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DepartmentName = table.Column<string>(maxLength: 255, nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentOsitel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOsitel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedById = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    EmployeeName = table.Column<string>(maxLength: 255, nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOsitel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentOsitel");

            migrationBuilder.DropTable(
                name: "EmployeeOsitel");
        }
    }
}
