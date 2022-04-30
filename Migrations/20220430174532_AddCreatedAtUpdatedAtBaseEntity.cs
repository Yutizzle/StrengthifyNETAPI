using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class AddCreatedAtUpdatedAtBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_increment_frequencies_users_created_by_user_id",
                table: "increment_frequencies");

            migrationBuilder.DropForeignKey(
                name: "fk_increment_frequencies_users_updated_by_user_id",
                table: "increment_frequencies");

            migrationBuilder.DropForeignKey(
                name: "fk_program_details_users_created_by_user_id",
                table: "program_details");

            migrationBuilder.DropForeignKey(
                name: "fk_program_details_users_updated_by_user_id",
                table: "program_details");

            migrationBuilder.DropForeignKey(
                name: "fk_programs_users_created_by_user_id",
                table: "programs");

            migrationBuilder.DropForeignKey(
                name: "fk_programs_users_updated_by_user_id",
                table: "programs");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_users_created_by_user_id",
                table: "workout_exercise_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_users_updated_by_user_id",
                table: "workout_exercise_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercises_users_created_by_user_id",
                table: "workout_exercises");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercises_users_updated_by_user_id",
                table: "workout_exercises");

            migrationBuilder.DropForeignKey(
                name: "fk_workouts_users_created_by_user_id",
                table: "workouts");

            migrationBuilder.DropForeignKey(
                name: "fk_workouts_users_updated_by_user_id",
                table: "workouts");

            migrationBuilder.RenameColumn(
                name: "updated_by_user_id",
                table: "workouts",
                newName: "updated_by_id");

            migrationBuilder.RenameColumn(
                name: "created_by_user_id",
                table: "workouts",
                newName: "created_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_workouts_updated_by_user_id",
                table: "workouts",
                newName: "ix_workouts_updated_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_workouts_created_by_user_id",
                table: "workouts",
                newName: "ix_workouts_created_by_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_user_id",
                table: "workout_exercises",
                newName: "updated_by_id");

            migrationBuilder.RenameColumn(
                name: "created_by_user_id",
                table: "workout_exercises",
                newName: "created_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_workout_exercises_updated_by_user_id",
                table: "workout_exercises",
                newName: "ix_workout_exercises_updated_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_workout_exercises_created_by_user_id",
                table: "workout_exercises",
                newName: "ix_workout_exercises_created_by_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_user_id",
                table: "workout_exercise_details",
                newName: "updated_by_id");

            migrationBuilder.RenameColumn(
                name: "created_by_user_id",
                table: "workout_exercise_details",
                newName: "created_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_workout_exercise_details_updated_by_user_id",
                table: "workout_exercise_details",
                newName: "ix_workout_exercise_details_updated_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_workout_exercise_details_created_by_user_id",
                table: "workout_exercise_details",
                newName: "ix_workout_exercise_details_created_by_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_user_id",
                table: "programs",
                newName: "updated_by_id");

            migrationBuilder.RenameColumn(
                name: "created_by_user_id",
                table: "programs",
                newName: "created_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_programs_updated_by_user_id",
                table: "programs",
                newName: "ix_programs_updated_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_programs_created_by_user_id",
                table: "programs",
                newName: "ix_programs_created_by_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_user_id",
                table: "program_details",
                newName: "updated_by_id");

            migrationBuilder.RenameColumn(
                name: "created_by_user_id",
                table: "program_details",
                newName: "created_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_program_details_updated_by_user_id",
                table: "program_details",
                newName: "ix_program_details_updated_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_program_details_created_by_user_id",
                table: "program_details",
                newName: "ix_program_details_created_by_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_user_id",
                table: "increment_frequencies",
                newName: "updated_by_id");

            migrationBuilder.RenameColumn(
                name: "created_by_user_id",
                table: "increment_frequencies",
                newName: "created_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_increment_frequencies_updated_by_user_id",
                table: "increment_frequencies",
                newName: "ix_increment_frequencies_updated_by_id");

            migrationBuilder.RenameIndex(
                name: "ix_increment_frequencies_created_by_user_id",
                table: "increment_frequencies",
                newName: "ix_increment_frequencies_created_by_id");

            migrationBuilder.AddForeignKey(
                name: "fk_increment_frequencies_users_created_by_id",
                table: "increment_frequencies",
                column: "created_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_increment_frequencies_users_updated_by_id",
                table: "increment_frequencies",
                column: "updated_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_program_details_users_created_by_id",
                table: "program_details",
                column: "created_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_program_details_users_updated_by_id",
                table: "program_details",
                column: "updated_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_programs_users_created_by_id",
                table: "programs",
                column: "created_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_programs_users_updated_by_id",
                table: "programs",
                column: "updated_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_users_created_by_id",
                table: "workout_exercise_details",
                column: "created_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_users_updated_by_id",
                table: "workout_exercise_details",
                column: "updated_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercises_users_created_by_id",
                table: "workout_exercises",
                column: "created_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercises_users_updated_by_id",
                table: "workout_exercises",
                column: "updated_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workouts_users_created_by_id",
                table: "workouts",
                column: "created_by_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workouts_users_updated_by_id",
                table: "workouts",
                column: "updated_by_id",
                principalTable: "users",
                principalColumn: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_increment_frequencies_users_created_by_id",
                table: "increment_frequencies");

            migrationBuilder.DropForeignKey(
                name: "fk_increment_frequencies_users_updated_by_id",
                table: "increment_frequencies");

            migrationBuilder.DropForeignKey(
                name: "fk_program_details_users_created_by_id",
                table: "program_details");

            migrationBuilder.DropForeignKey(
                name: "fk_program_details_users_updated_by_id",
                table: "program_details");

            migrationBuilder.DropForeignKey(
                name: "fk_programs_users_created_by_id",
                table: "programs");

            migrationBuilder.DropForeignKey(
                name: "fk_programs_users_updated_by_id",
                table: "programs");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_users_created_by_id",
                table: "workout_exercise_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_users_updated_by_id",
                table: "workout_exercise_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercises_users_created_by_id",
                table: "workout_exercises");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercises_users_updated_by_id",
                table: "workout_exercises");

            migrationBuilder.DropForeignKey(
                name: "fk_workouts_users_created_by_id",
                table: "workouts");

            migrationBuilder.DropForeignKey(
                name: "fk_workouts_users_updated_by_id",
                table: "workouts");

            migrationBuilder.RenameColumn(
                name: "updated_by_id",
                table: "workouts",
                newName: "updated_by_user_id");

            migrationBuilder.RenameColumn(
                name: "created_by_id",
                table: "workouts",
                newName: "created_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_workouts_updated_by_id",
                table: "workouts",
                newName: "ix_workouts_updated_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_workouts_created_by_id",
                table: "workouts",
                newName: "ix_workouts_created_by_user_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_id",
                table: "workout_exercises",
                newName: "updated_by_user_id");

            migrationBuilder.RenameColumn(
                name: "created_by_id",
                table: "workout_exercises",
                newName: "created_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_workout_exercises_updated_by_id",
                table: "workout_exercises",
                newName: "ix_workout_exercises_updated_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_workout_exercises_created_by_id",
                table: "workout_exercises",
                newName: "ix_workout_exercises_created_by_user_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_id",
                table: "workout_exercise_details",
                newName: "updated_by_user_id");

            migrationBuilder.RenameColumn(
                name: "created_by_id",
                table: "workout_exercise_details",
                newName: "created_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_workout_exercise_details_updated_by_id",
                table: "workout_exercise_details",
                newName: "ix_workout_exercise_details_updated_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_workout_exercise_details_created_by_id",
                table: "workout_exercise_details",
                newName: "ix_workout_exercise_details_created_by_user_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_id",
                table: "programs",
                newName: "updated_by_user_id");

            migrationBuilder.RenameColumn(
                name: "created_by_id",
                table: "programs",
                newName: "created_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_programs_updated_by_id",
                table: "programs",
                newName: "ix_programs_updated_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_programs_created_by_id",
                table: "programs",
                newName: "ix_programs_created_by_user_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_id",
                table: "program_details",
                newName: "updated_by_user_id");

            migrationBuilder.RenameColumn(
                name: "created_by_id",
                table: "program_details",
                newName: "created_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_program_details_updated_by_id",
                table: "program_details",
                newName: "ix_program_details_updated_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_program_details_created_by_id",
                table: "program_details",
                newName: "ix_program_details_created_by_user_id");

            migrationBuilder.RenameColumn(
                name: "updated_by_id",
                table: "increment_frequencies",
                newName: "updated_by_user_id");

            migrationBuilder.RenameColumn(
                name: "created_by_id",
                table: "increment_frequencies",
                newName: "created_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_increment_frequencies_updated_by_id",
                table: "increment_frequencies",
                newName: "ix_increment_frequencies_updated_by_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_increment_frequencies_created_by_id",
                table: "increment_frequencies",
                newName: "ix_increment_frequencies_created_by_user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_increment_frequencies_users_created_by_user_id",
                table: "increment_frequencies",
                column: "created_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_increment_frequencies_users_updated_by_user_id",
                table: "increment_frequencies",
                column: "updated_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_program_details_users_created_by_user_id",
                table: "program_details",
                column: "created_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_program_details_users_updated_by_user_id",
                table: "program_details",
                column: "updated_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_programs_users_created_by_user_id",
                table: "programs",
                column: "created_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_programs_users_updated_by_user_id",
                table: "programs",
                column: "updated_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_users_created_by_user_id",
                table: "workout_exercise_details",
                column: "created_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_users_updated_by_user_id",
                table: "workout_exercise_details",
                column: "updated_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercises_users_created_by_user_id",
                table: "workout_exercises",
                column: "created_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercises_users_updated_by_user_id",
                table: "workout_exercises",
                column: "updated_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workouts_users_created_by_user_id",
                table: "workouts",
                column: "created_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workouts_users_updated_by_user_id",
                table: "workouts",
                column: "updated_by_user_id",
                principalTable: "users",
                principalColumn: "user_id");
        }
    }
}
