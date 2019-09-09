using Microsoft.EntityFrameworkCore.Migrations;

namespace Uni_Dash.Migrations
{
    public partial class HashLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginHashs",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    pwd = table.Column<string>(nullable: true),
                    hashPwd = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHashs", x => x.user);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginHashs");
        }
    }
}
