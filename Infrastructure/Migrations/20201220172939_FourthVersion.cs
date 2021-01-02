using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class FourthVersion : Migration
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

            migrationBuilder.AddColumn<decimal>(
                name: "Logs",
                table: "Servers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logs",
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
