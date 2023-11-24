using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "ca34a35b-f845-4b9d-9e72-a3998cd35bb9", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEH/geHrKDrCP46jRMxxkEyVIFUcwkuyA9rRnb5uUzApbzgB9+6bcXH0EmIFTgAC3gw==", null, false, "96a612f3-cb34-4538-ab3a-0ecfcb15f87e", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(4735), new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(4760), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(4764), new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(4765), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5578), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5581), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5982), new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5984), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5987), new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5988), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5990), new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5991), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 11, 24, 10, 56, 13, 386, DateTimeKind.Local).AddTicks(5994), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
