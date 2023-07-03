using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalApplication.Server.Data.Migrations
{
    public partial class AddedSeedConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8251), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8264), "Black", "System" },
                    { 2, "System", new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8267), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8267), "Blue", "System" },
                    { 3, "System", new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8268), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8269), "White", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "ID", "Brand", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "BMW", "System", new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8672), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8673), "System" },
                    { 2, "Toyota", "System", new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8674), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8675), "System" },
                    { 3, "Hyundai", "System", new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8676), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8676), "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8573), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8571), "Model 1", "System" },
                    { 2, "System", new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 7, 3, 10, 0, 21, 129, DateTimeKind.Local).AddTicks(8575), "Model 2", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
