using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SweDemoBackend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LegoSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPieces = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegoSet", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LegoSet",
                columns: new[] { "Id", "Name", "NumberOfPieces" },
                values: new object[] { new Guid("f3c73d8d-5f8a-4f2a-9c11-2c9a1c2f8d2e"), "Harry Potter Zweinstein", 1540 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LegoSet");
        }
    }
}
