using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class AddModelSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "user_id", "created_at", "created_by_id", "date_of_birth", "email", "first_name", "last_name", "program_id", "program_run", "updated_at", "updated_by_id", "uuid", "workout_id" },
                values: new object[] { 1, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, new DateTime(1994, 2, 3, 0, 0, 0, 0, DateTimeKind.Utc), "admin@admin.com", "Admin", "Admin", null, 0, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, new Guid("c5726903-9238-481f-82b1-c044d13dc4fc"), null });

            migrationBuilder.InsertData(
                table: "programs",
                columns: new[] { "program_id", "created_at", "created_by_id", "program_name", "total_cycle_days", "updated_at", "updated_by_id" },
                values: new object[] { 7, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Simple 3x5", 4, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1 });

            migrationBuilder.InsertData(
                table: "workouts",
                columns: new[] { "workout_id", "created_at", "created_by_id", "image_object_id", "updated_at", "updated_by_id", "workout_name" },
                values: new object[,]
                {
                    { 8, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, null, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Bench Day" },
                    { 10, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, null, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Squat Day" },
                    { 12, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, null, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Overhead Press Day" },
                    { 14, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, null, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Deadlift Day" }
                });

            migrationBuilder.InsertData(
                table: "program_details",
                columns: new[] { "program_detail_id", "created_at", "created_by_id", "cycle_day_num", "program_id", "sequence_num", "updated_at", "updated_by_id", "workout_id" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 1, 7, 0, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 8 },
                    { 11, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 2, 7, 1, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 10 },
                    { 13, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 3, 7, 2, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 12 },
                    { 15, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 4, 7, 3, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 14 }
                });

            migrationBuilder.InsertData(
                table: "workout_exercises",
                columns: new[] { "workout_exercise_id", "created_at", "created_by_id", "exercise", "sequence_num", "updated_at", "updated_by_id", "workout_id" },
                values: new object[,]
                {
                    { 16, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Bench Press", 0, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 8 },
                    { 17, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Overhead Press", 1, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 8 },
                    { 18, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "T-Bar Row", 2, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 8 },
                    { 19, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Tricep Pushdown", 3, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 8 },
                    { 20, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Dumbbell Bicep Curl", 4, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 8 },
                    { 21, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Squat", 0, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 10 },
                    { 22, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Romanian Deadlift", 1, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 10 },
                    { 23, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Lat Pull Down", 2, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 10 },
                    { 24, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Bulgarian Split Squat", 3, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 10 },
                    { 25, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Jump Rope", 4, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 10 },
                    { 26, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Overhead Press", 0, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 12 },
                    { 27, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Incline Bench Press", 1, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 12 },
                    { 28, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Barbell Row", 2, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 12 },
                    { 29, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Tricep Overhead Extension", 3, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 12 },
                    { 30, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Dumbbell Lat Raise", 4, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 12 },
                    { 31, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Deadlift", 0, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 14 },
                    { 32, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Front Squat", 1, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 14 },
                    { 33, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Pull-up", 2, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 14 },
                    { 34, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Glute Raise", 3, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 14 },
                    { 35, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, "Face Pull", 4, new DateTime(2022, 5, 1, 8, 4, 24, 916, DateTimeKind.Utc).AddTicks(1360), 1, 14 }
                });

            migrationBuilder.InsertData(
                table: "workout_exercise_details",
                columns: new[] { "workout_exercise_detail_id", "created_at", "created_by_id", "max_reps", "max_set_duration", "max_weight", "reps", "reps_increment_amount", "reps_increment_frequency_id", "set", "set_duration", "set_duration_increment_amount", "set_duration_increment_frequency_id", "set_rest_duration", "updated_at", "updated_by_id", "weight", "weight_increment_amount", "weight_increment_frequency_id", "workout_exercise_id" },
                values: new object[,]
                {
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 155, 0, null, 16 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 155, 0, null, 16 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 155, 0, null, 16 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85, 0, null, 17 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85, 0, null, 17 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85, 0, null, 17 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100, 0, null, 18 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100, 0, null, 18 },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100, 0, null, 18 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, 0, null, 19 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, 0, null, 19 },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, 0, null, 19 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, 0, null, 20 },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, 0, null, 20 },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, 0, null, 20 },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 185, 0, null, 21 },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 185, 0, null, 21 },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 185, 0, null, 21 },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 22 },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 22 },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 22 },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, 0, null, 23 },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, 0, null, 23 },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, 0, null, 23 },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 0, null, 24 },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 0, null, 24 },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 0, null, 24 },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 0, 0, null, 1, 30, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, null, 25 },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 0, 0, null, 2, 30, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, null, 25 },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 0, 0, null, 3, 30, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, null, 25 },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 26 },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 26 },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 26 },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85, 0, null, 27 },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85, 0, null, 27 },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85, 0, null, 27 },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 28 },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 28 },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 28 },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, 0, null, 29 },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, 0, null, 29 },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, 0, null, 29 },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 0, null, 30 },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 0, null, 30 },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 0, null, 30 },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 225, 0, null, 31 },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 225, 0, null, 31 },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 5, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 225, 0, null, 31 },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 32 },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 32 },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 32 },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, null, 33 },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, null, 33 },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, null, 33 },
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 34 },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 34 },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, 0, null, 34 },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 1, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, 0, null, 35 },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 2, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, 0, null, 35 },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0, 0, 8, 0, null, 3, 0, 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, 0, null, 35 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "program_details",
                keyColumn: "program_detail_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "workout_exercise_details",
                keyColumn: "workout_exercise_detail_id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "programs",
                keyColumn: "program_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "workout_exercises",
                keyColumn: "workout_exercise_id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "workouts",
                keyColumn: "workout_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1);
        }
    }
}
