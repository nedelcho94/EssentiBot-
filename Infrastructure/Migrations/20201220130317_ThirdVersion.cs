using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ThirdVersion : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "Background",
                table: "Servers",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Welcome",
                table: "Servers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Background",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "Welcome",
                table: "Servers");

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
