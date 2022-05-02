using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class AddIncrementFrequenciesSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "increment_frequencies",
                columns: new[] { "increment_frequency_id", "created_at", "created_by_id", "frequency", "updated_at", "updated_by_id" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1, "CYCLE_END", new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1 },
                    { 3, new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1, "MAX_REPS_REACHED", new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1 },
                    { 4, new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1, "MAX_WEIGHT_REACHED", new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1 },
                    { 5, new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1, "NEW_PR", new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1 },
                    { 6, new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1, "MAX_SET_DURATION_REACHED", new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), 1 }
                });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "programs",
                keyColumn: "program_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at", "uuid" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new Guid("8a6069de-9e2e-4b0f-b5fb-36cf4df582ad") });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 5, 1, 8, 6, 21, 354, DateTimeKind.Utc).AddTicks(797) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "increment_frequencies",
                keyColumn: "increment_frequency_id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "programs",
                keyColumn: "program_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at", "uuid" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new Guid("c5726903-9238-481f-82b1-c044d13dc4fc") });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360) });
        }
    }
}
