using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class @in : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AspNetUsers_CarOwner",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarOwner",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "ClientNumber",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "AvailableBagPlaces",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalDate",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartureDate",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CarOwner",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalDate",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "DepartureDate",
                table: "Trips");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalTime",
                table: "Trips",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ClientNumber",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CarOwner",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AvailableBagPlaces",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarOwner",
                table: "Cars",
                column: "CarOwner",
                unique: true,
                filter: "[CarOwner] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AspNetUsers_CarOwner",
                table: "Cars",
                column: "CarOwner",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
