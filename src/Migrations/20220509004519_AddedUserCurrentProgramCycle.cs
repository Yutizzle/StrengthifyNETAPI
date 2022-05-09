using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class AddedUserCurrentProgramCycle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "current_program_cycle",
                table: "users",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "programs",
                keyColumn: "program_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at", "uuid" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new Guid("05c68409-a38b-488f-a493-285093b05ca8") });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 37,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 38,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 39,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 40,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 41,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 42,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 43,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 44,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 45,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 46,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 47,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 48,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 49,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 50,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 51,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 52,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 53,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 54,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 55,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 56,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 57,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 58,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 59,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 60,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 61,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 62,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 63,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 64,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 65,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 66,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 67,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 68,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 69,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 70,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 71,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 72,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 73,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 74,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 75,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 76,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 77,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 78,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 79,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 80,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 81,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 82,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 83,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 84,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 85,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 86,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 87,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 88,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 89,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 90,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 91,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 92,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 93,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 94,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 95,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 9, 0, 45, 18, 951, DateTimeKind.Utc).AddTicks(7579) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "current_program_cycle",
                table: "users");

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "programs",
                keyColumn: "program_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at", "uuid" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new Guid("29ed5754-b19a-41fb-a902-6503717850ad") });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 37,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 38,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 39,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 40,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 41,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 42,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 43,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 44,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 45,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 46,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 47,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 48,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 49,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 50,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 51,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 52,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 53,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 54,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 55,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 56,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 57,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 58,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 59,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 60,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 61,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 62,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 63,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 64,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 65,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 66,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 67,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 68,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 69,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 70,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 71,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 72,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 73,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 74,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 75,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 76,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 77,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 78,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 79,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 80,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 81,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 82,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 83,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 84,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 85,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 86,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 87,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 88,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 89,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 90,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 91,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 92,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 93,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 94,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 95,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 5, 1, 8, 9, 29, 62, DateTimeKind.Utc).AddTicks(3678) });
        }
    }
}
