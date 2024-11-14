using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dorixona.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatePharm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pharm",
                columns: table => new
                {
                    PharmId = table.Column<string>(type: "text", nullable: false),
                    PharmName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    PharmAddress = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    PharmPhoneNumber = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pharm", x => x.PharmId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pharm");
        }
    }
}
