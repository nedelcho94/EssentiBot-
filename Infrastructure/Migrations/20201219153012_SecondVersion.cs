using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SecondVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Id",
            //    table: "Servers",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(20,0)")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "AutoRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<decimal>(nullable: false),
                    ServerId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<decimal>(nullable: false),
                    ServerId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoRoles");

            migrationBuilder.DropTable(
                name: "Ranks");

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Id",
            //    table: "Servers",
            //    type: "decimal(20,0)",
            //    nullable: false,
            //    oldClrType: typeof(decimal))
            //    .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
