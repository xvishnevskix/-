using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace КурсовойПроект.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "817F6C5F-3636-4120-A2EA-104449CD5834", "99cbb0b2-ef3e-4a85-914a-49d4a79846a9", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "B3E76A8D-5D72-4B3D-AFE3-A2E79E687F93", 0, "97d64b2d-a648-49e4-9654-70762b6c6aed", "my@emil.ru", true, false, null, "MY@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEAqAB4teSKfc0V07FCfYaodZ28/UaHLSOBYiCneHkRBvhI5Wm3zzU/HmfZy/49/7Sw==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("4428838e-be1d-4c57-9275-98cb7daa3294"), "PageIndex", new DateTime(2020, 12, 24, 18, 3, 42, 825, DateTimeKind.Utc).AddTicks(8197), null, null, null, null, "Содержание заполняется администратором", "Главная", null },
                    { new Guid("b6d9259c-4053-4a5b-8eb6-47306832cf62"), "PageServices", new DateTime(2020, 12, 24, 18, 3, 42, 826, DateTimeKind.Utc).AddTicks(1065), null, null, null, null, "Содержание заполняется администратором", "Наши услуги", null },
                    { new Guid("309d7fc1-5eb2-4a24-93e4-ae222692a1fb"), "PageContacts", new DateTime(2020, 12, 24, 18, 3, 42, 826, DateTimeKind.Utc).AddTicks(1140), null, null, null, null, "Содержание заполняется администратором", "Контакты", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "817F6C5F-3636-4120-A2EA-104449CD5834", "B3E76A8D-5D72-4B3D-AFE3-A2E79E687F93" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "817F6C5F-3636-4120-A2EA-104449CD5834", "B3E76A8D-5D72-4B3D-AFE3-A2E79E687F93" });

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("309d7fc1-5eb2-4a24-93e4-ae222692a1fb"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4428838e-be1d-4c57-9275-98cb7daa3294"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6d9259c-4053-4a5b-8eb6-47306832cf62"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "817F6C5F-3636-4120-A2EA-104449CD5834");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B3E76A8D-5D72-4B3D-AFE3-A2E79E687F93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "47d5d8ce-286e-4636-a03e-62116ce37bf9", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b62472e-4f66-49fa-a20f-e7685b9565d8", 0, "1278c768-7754-480e-b545-edb0a16df042", "my@email.com", true, false, null, "MY@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEGZKOrmG0BfkGn/5M8KRnTLTFrIwu4JLtqZ4JW8zF3I1YChKmb/zZcKoBgIzRVM0dA==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), "PageIndex", new DateTime(2020, 12, 24, 17, 56, 52, 248, DateTimeKind.Utc).AddTicks(7457), null, null, null, null, "Содержание заполняется администратором", "Главная", null },
                    { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), "PageServices", new DateTime(2020, 12, 24, 17, 56, 52, 249, DateTimeKind.Utc).AddTicks(591), null, null, null, null, "Содержание заполняется администратором", "Наши услуги", null },
                    { new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), "PageContacts", new DateTime(2020, 12, 24, 17, 56, 52, 249, DateTimeKind.Utc).AddTicks(679), null, null, null, null, "Содержание заполняется администратором", "Контакты", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });
        }
    }
}
