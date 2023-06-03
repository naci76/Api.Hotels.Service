using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Hotels.Entity.Migrations
{
    public partial class hotelideklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hotelContacts_Hotels_HotelId",
                table: "hotelContacts");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "hotelContacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_hotelContacts_Hotels_HotelId",
                table: "hotelContacts",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hotelContacts_Hotels_HotelId",
                table: "hotelContacts");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "hotelContacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_hotelContacts_Hotels_HotelId",
                table: "hotelContacts",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
