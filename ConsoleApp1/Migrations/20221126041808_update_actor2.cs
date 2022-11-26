using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAPI6.Migrations
{
    /// <inheritdoc />
    public partial class updateactor2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "CreateUpdate",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Actors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Actors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateUpdate",
                table: "Actors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Actors",
                type: "datetime2",
                nullable: true);
        }
    }
}
