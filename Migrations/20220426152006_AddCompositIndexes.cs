using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class AddCompositIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_workout_exercises_workout_id",
                table: "workout_exercises");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_workout_exercise_id",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_program_details_program_id",
                table: "program_details");

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
                name: "ix_program_details_program_id_workout_id",
                table: "program_details",
                columns: new[] { "program_id", "workout_id" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_workout_exercises_workout_id_exercise",
                table: "workout_exercises");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_workout_exercise_id_set",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_program_details_program_id_workout_id",
                table: "program_details");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_workout_id",
                table: "workout_exercises",
                column: "workout_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_workout_exercise_id",
                table: "workout_exercise_details",
                column: "workout_exercise_id");

            migrationBuilder.CreateIndex(
                name: "ix_program_details_program_id",
                table: "program_details",
                column: "program_id");
        }
    }
}
