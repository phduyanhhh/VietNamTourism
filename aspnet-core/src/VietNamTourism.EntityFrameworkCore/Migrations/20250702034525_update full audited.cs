using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VietNamTourism.Migrations
{
    /// <inheritdoc />
    public partial class updatefullaudited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "TourismDB",
                table: "Provinces",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                schema: "TourismDB",
                table: "Provinces",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "TourismDB",
                table: "Provinces",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                schema: "TourismDB",
                table: "Provinces",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "TourismDB",
                table: "Provinces",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                schema: "TourismDB",
                table: "Provinces",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                schema: "TourismDB",
                table: "Provinces",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "TourismDB",
                table: "Districts",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                schema: "TourismDB",
                table: "Districts",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "TourismDB",
                table: "Districts",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                schema: "TourismDB",
                table: "Districts",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "TourismDB",
                table: "Districts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                schema: "TourismDB",
                table: "Districts",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                schema: "TourismDB",
                table: "Districts",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "TourismDB",
                table: "Communes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                schema: "TourismDB",
                table: "Communes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "TourismDB",
                table: "Communes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                schema: "TourismDB",
                table: "Communes",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "TourismDB",
                table: "Communes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                schema: "TourismDB",
                table: "Communes",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                schema: "TourismDB",
                table: "Communes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "TourismDB",
                table: "AdministrativeLocations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                schema: "TourismDB",
                table: "AdministrativeLocations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "TourismDB",
                table: "AdministrativeLocations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                schema: "TourismDB",
                table: "AdministrativeLocations",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "TourismDB",
                table: "AdministrativeLocations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                schema: "TourismDB",
                table: "AdministrativeLocations",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                schema: "TourismDB",
                table: "AdministrativeLocations",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "TourismDB",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                schema: "TourismDB",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "TourismDB",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                schema: "TourismDB",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "TourismDB",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                schema: "TourismDB",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                schema: "TourismDB",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "TourismDB",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                schema: "TourismDB",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "TourismDB",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                schema: "TourismDB",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "TourismDB",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                schema: "TourismDB",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                schema: "TourismDB",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "TourismDB",
                table: "Communes");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                schema: "TourismDB",
                table: "Communes");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "TourismDB",
                table: "Communes");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                schema: "TourismDB",
                table: "Communes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "TourismDB",
                table: "Communes");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                schema: "TourismDB",
                table: "Communes");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                schema: "TourismDB",
                table: "Communes");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "TourismDB",
                table: "AdministrativeLocations");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                schema: "TourismDB",
                table: "AdministrativeLocations");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "TourismDB",
                table: "AdministrativeLocations");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                schema: "TourismDB",
                table: "AdministrativeLocations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "TourismDB",
                table: "AdministrativeLocations");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                schema: "TourismDB",
                table: "AdministrativeLocations");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                schema: "TourismDB",
                table: "AdministrativeLocations");
        }
    }
}
