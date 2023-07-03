using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalApplication.Server.Data.Migrations
{
    public partial class AddedRoleSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57947f0f-0a23-41c2-9d68-b8380997be21", "d5f94b70-52e3-4659-890e-6ee02bf60505", "Administrator", "ADMINISTRATOR" },
                    { "67947f1f-1a34-42c2-9e68-b8380997be22", "5dfbbea9-d099-4d91-86be-cda8ff276d29", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5439), new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5684), new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5687), new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5688), new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5629), new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5630), new DateTime(2023, 7, 3, 10, 32, 21, 590, DateTimeKind.Local).AddTicks(5630) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57947f0f-0a23-41c2-9d68-b8380997be21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67947f1f-1a34-42c2-9e68-b8380997be22");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8251), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8267), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8268), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8672), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8674), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8676), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8573), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8575) });
        }
    }
}
