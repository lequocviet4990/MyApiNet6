using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAPI6.Migrations
{
    /// <inheritdoc />
    public partial class updateactormovivie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateUpdate",
                table: "Movies",
                newName: "UpdateDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Actors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Actors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Actors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Actors");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Movies",
                newName: "CreateUpdate");
        }
    }
}
