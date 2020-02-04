using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logs.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    idLog = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    Date_Register = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idLog);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Log");
        }
    }
}
