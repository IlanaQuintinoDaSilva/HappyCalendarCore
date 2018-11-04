using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HappyCalendarCore.Migrations
{
    public partial class categoryProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "value",
                table: "Project",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Project",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "Project");

            migrationBuilder.AlterColumn<double>(
                name: "value",
                table: "Project",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "decimal(18, 2)");
        }
    }
}
