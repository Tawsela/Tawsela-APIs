using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BL.Migrations
{
    public partial class updateto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartialTime",
                table: "Trips");

            migrationBuilder.RenameColumn(
                name: "LocationTo",
                table: "Trips",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "LocationFrom",
                table: "Trips",
                newName: "RecommPrice");

            migrationBuilder.RenameColumn(
                name: "DepartureDate",
                table: "Trips",
                newName: "Notice");

            migrationBuilder.RenameColumn(
                name: "ArrivalDate",
                table: "Trips",
                newName: "Destination");

            migrationBuilder.AddColumn<string>(
                name: "AvilablePassengers",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Departure",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvilablePassengers",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Departure",
                table: "Trips");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Trips",
                newName: "LocationTo");

            migrationBuilder.RenameColumn(
                name: "RecommPrice",
                table: "Trips",
                newName: "LocationFrom");

            migrationBuilder.RenameColumn(
                name: "Notice",
                table: "Trips",
                newName: "DepartureDate");

            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "Trips",
                newName: "ArrivalDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartialTime",
                table: "Trips",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
