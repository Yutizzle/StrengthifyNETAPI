using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class FixAllIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_workout_exercises_workout_id_exercise",
                table: "workout_exercises");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_workout_exercise_id_set",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_programs_program_name",
                table: "programs");

            migrationBuilder.DropIndex(
                name: "ix_program_details_program_id_workout_id",
                table: "program_details");

            migrationBuilder.DropIndex(
                name: "ix_increment_frequencies_frequency",
                table: "increment_frequencies");

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "programs",
                keyColumn: "program_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at", "uuid" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new Guid("37e9433e-3cfe-43bf-a26e-82f41cc20dbc") });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 37,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 38,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 39,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 40,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 41,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 42,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 43,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 44,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 45,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 46,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 47,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 48,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 49,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 50,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 51,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 52,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 53,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 54,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 55,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 56,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 57,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 58,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 59,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 60,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 61,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 62,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 63,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 64,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 65,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 66,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 67,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 68,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 69,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 70,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 71,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 72,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 73,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 74,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 75,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 76,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 77,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 78,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 79,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 80,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 81,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 82,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 83,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 84,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 85,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 86,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 87,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 88,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 89,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 90,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 91,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 92,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 93,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 94,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 95,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857), new DateTime(2022, 5, 20, 4, 29, 11, 930, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_workout_exercise_id_workout_id",
                table: "workout_exercises",
                columns: new[] { "workout_exercise_id", "workout_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_workout_id",
                table: "workout_exercises",
                column: "workout_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_workout_exercise_detail_id_workout",
                table: "workout_exercise_details",
                columns: new[] { "workout_exercise_detail_id", "workout_exercise_id", "set" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_workout_exercise_id",
                table: "workout_exercise_details",
                column: "workout_exercise_id");

            migrationBuilder.CreateIndex(
                name: "ix_programs_program_id_program_name",
                table: "programs",
                columns: new[] { "program_id", "program_name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_program_details_program_detail_id_program_id_workout_id",
                table: "program_details",
                columns: new[] { "program_detail_id", "program_id", "workout_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_program_details_program_id",
                table: "program_details",
                column: "program_id");

            migrationBuilder.CreateIndex(
                name: "ix_increment_frequencies_increment_frequency_id_frequency",
                table: "increment_frequencies",
                columns: new[] { "increment_frequency_id", "frequency" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_workout_exercises_workout_exercise_id_workout_id",
                table: "workout_exercises");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercises_workout_id",
                table: "workout_exercises");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_workout_exercise_detail_id_workout",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_workout_exercise_id",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_programs_program_id_program_name",
                table: "programs");

            migrationBuilder.DropIndex(
                name: "ix_program_details_program_detail_id_program_id_workout_id",
                table: "program_details");

            migrationBuilder.DropIndex(
                name: "ix_program_details_program_id",
                table: "program_details");

            migrationBuilder.DropIndex(
                name: "ix_increment_frequencies_increment_frequency_id_frequency",
                table: "increment_frequencies");

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "programs",
                keyColumn: "program_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at", "uuid" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new Guid("6d5a8dad-0f3d-4270-80f0-b0c7b7bcd50f") });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 37,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 38,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 39,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 40,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 41,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 42,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 43,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 44,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 45,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 46,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 47,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 48,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 49,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 50,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 51,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 52,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 53,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 54,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 55,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 56,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 57,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 58,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 59,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 60,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 61,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 62,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 63,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 64,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 65,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 66,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 67,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 68,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 69,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 70,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 71,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 72,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 73,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 74,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 75,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 76,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 77,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 78,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 79,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 80,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 81,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 82,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 83,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 84,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 85,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 86,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 87,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 88,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 89,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 90,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 91,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 92,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 93,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 94,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 95,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 5, 20, 4, 23, 12, 74, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_workout_id_exercise",
                table: "workout_exercises",
                columns: new[] { "workout_id", "exercise" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_workout_exercise_id_set",
                table: "workout_exercise_details",
                columns: new[] { "workout_exercise_id", "set" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_programs_program_name",
                table: "programs",
                column: "program_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_program_details_program_id_workout_id",
                table: "program_details",
                columns: new[] { "program_id", "workout_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_increment_frequencies_frequency",
                table: "increment_frequencies",
                column: "frequency",
                unique: true);
        }
    }
}
