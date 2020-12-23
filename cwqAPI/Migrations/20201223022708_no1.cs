using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cwqAPI.Migrations
{
    public partial class no1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Username = table.Column<string>(maxLength: 10, nullable: false),
                    Pubdate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Grade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "petpictures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(maxLength: 150, nullable: true),
                    PostId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_petpictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_petpictures_posts_PostId",
                        column: x => x.PostId,
                        principalTable: "posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_petpictures_PostId",
                table: "petpictures",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "petpictures");

            migrationBuilder.DropTable(
                name: "posts");
        }
    }
}
