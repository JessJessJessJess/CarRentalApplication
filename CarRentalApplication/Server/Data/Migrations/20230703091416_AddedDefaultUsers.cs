using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalApplication.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57947f0f-0a23-41c2-9d68-b8380997be21",
                column: "ConcurrencyStamp",
                value: "0b1457bc-82b5-4c9c-ad8e-9431b6862cea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67947f1f-1a34-42c2-9e68-b8380997be22",
                column: "ConcurrencyStamp",
                value: "b39651a5-cb76-4eab-a3fa-a713b2f10cf8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b844869-f724-4dbf-9b5a-3d25e9a369ec", 0, "2dd47e7f-48cf-4b73-8e25-d6d7c83b3f8b", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJ8HYOKmrr4/o4VPVHvNFcTqTNP0d998P1es/SDkRN1qc6j1YxNzDoXuHLBBy/Ee5g==", null, false, "9ac4885d-1f69-4200-be91-df175777844b", false, "admin@localhost.com" },
                    { "1b844869-f734-5dbf-ab5a-4d25e9a369ec", 0, "87ef1934-081d-4f92-94c6-e7ea87a8a14b", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAELg73KvzpL2JiM+zAfKr5cuJ9F9n8kb37Yfv5ij6uoRcOO5phLMida+jksUqZGW+kQ==", null, false, "bbe12028-1df6-4ef2-a45d-8f6a32ad4744", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 14, 15, 934, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 7, 3, 11, 14, 15, 934, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 14, 15, 934, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 7, 3, 11, 14, 15, 934, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 14, 15, 934, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 7, 3, 11, 14, 15, 934, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(118), new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(120), new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(28), new DateTime(2023, 7, 3, 11, 14, 15, 935, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57947f0f-0a23-41c2-9d68-b8380997be21", "0b844869-f724-4dbf-9b5a-3d25e9a369ec" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "67947f1f-1a34-42c2-9e68-b8380997be22", "1b844869-f734-5dbf-ab5a-4d25e9a369ec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57947f0f-0a23-41c2-9d68-b8380997be21", "0b844869-f724-4dbf-9b5a-3d25e9a369ec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67947f1f-1a34-42c2-9e68-b8380997be22", "1b844869-f734-5dbf-ab5a-4d25e9a369ec" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b844869-f724-4dbf-9b5a-3d25e9a369ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b844869-f734-5dbf-ab5a-4d25e9a369ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57947f0f-0a23-41c2-9d68-b8380997be21",
                column: "ConcurrencyStamp",
                value: "d5f94b70-52e3-4659-890e-6ee02bf60505");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67947f1f-1a34-42c2-9e68-b8380997be22",
                column: "ConcurrencyStamp",
                value: "5dfbbea9-d099-4d91-86be-cda8ff276d29");

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
    }
}
