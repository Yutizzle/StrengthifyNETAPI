using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class AddUniqueIndexesAndForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_workouts_workout_name",
                table: "workouts",
                column: "workout_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_workout_id",
                table: "workout_exercises",
                column: "workout_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_workout_exercise_id",
                table: "workout_exercise_details",
                column: "workout_exercise_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_uuid",
                table: "users",
                column: "uuid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_programs_program_name",
                table: "programs",
                column: "program_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_program_details_program_id",
                table: "program_details",
                column: "program_id");

            migrationBuilder.CreateIndex(
                name: "ix_increment_frequencies_frequency",
                table: "increment_frequencies",
                column: "frequency",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_program_details_programs_program_id",
                table: "program_details",
                column: "program_id",
                principalTable: "programs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_workout_exercises_workout_exercise",
                table: "workout_exercise_details",
                column: "workout_exercise_id",
                principalTable: "workout_exercises",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercises_workouts_workout_id",
                table: "workout_exercises",
                column: "workout_id",
                principalTable: "workouts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_program_details_programs_program_id",
                table: "program_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_workout_exercises_workout_exercise",
                table: "workout_exercise_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercises_workouts_workout_id",
                table: "workout_exercises");

            migrationBuilder.DropIndex(
                name: "ix_workouts_workout_name",
                table: "workouts");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercises_workout_id",
                table: "workout_exercises");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_workout_exercise_id",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_users_uuid",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_programs_program_name",
                table: "programs");

            migrationBuilder.DropIndex(
                name: "ix_program_details_program_id",
                table: "program_details");

            migrationBuilder.DropIndex(
                name: "ix_increment_frequencies_frequency",
                table: "increment_frequencies");
        }
    }
}
