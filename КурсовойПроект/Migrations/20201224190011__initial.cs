using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace КурсовойПроект.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "817F6C5F-3636-4120-A2EA-104449CD5834",
                column: "ConcurrencyStamp",
                value: "eba58caa-b5c0-44e4-bab1-160c53e1a59b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B3E76A8D-5D72-4B3D-AFE3-A2E79E687F93",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da1ae809-5b30-40b6-88d1-25f8f4e70d3c", "AQAAAAEAACcQAAAAEF9PdezwgonZzc5DoGzGl6xv17nNMGuQK9agiQa4Kip4Gw48kjW3A/PHcc7hvxKsUw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("309d7fc1-5eb2-4a24-93e4-ae222692a1fb"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 24, 19, 0, 10, 69, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4428838e-be1d-4c57-9275-98cb7daa3294"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 24, 19, 0, 10, 68, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6d9259c-4053-4a5b-8eb6-47306832cf62"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 24, 19, 0, 10, 69, DateTimeKind.Utc).AddTicks(1817));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ServiceItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "817F6C5F-3636-4120-A2EA-104449CD5834",
                column: "ConcurrencyStamp",
                value: "99cbb0b2-ef3e-4a85-914a-49d4a79846a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B3E76A8D-5D72-4B3D-AFE3-A2E79E687F93",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97d64b2d-a648-49e4-9654-70762b6c6aed", "AQAAAAEAACcQAAAAEAqAB4teSKfc0V07FCfYaodZ28/UaHLSOBYiCneHkRBvhI5Wm3zzU/HmfZy/49/7Sw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("309d7fc1-5eb2-4a24-93e4-ae222692a1fb"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 24, 18, 3, 42, 826, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4428838e-be1d-4c57-9275-98cb7daa3294"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 24, 18, 3, 42, 825, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6d9259c-4053-4a5b-8eb6-47306832cf62"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 24, 18, 3, 42, 826, DateTimeKind.Utc).AddTicks(1065));
        }
    }
}
