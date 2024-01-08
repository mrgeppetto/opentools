using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace opentools.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OtNoteItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OtNoteName = table.Column<string>(type: "TEXT", nullable: false),
                    OtNoteDescription = table.Column<string>(type: "TEXT", nullable: false),
                    OtCreateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OtCompletedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OtIsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtNoteItem", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OtNoteItem");
        }
    }
}
