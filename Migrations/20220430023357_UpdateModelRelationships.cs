using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class UpdateModelRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "workouts",
                newName: "workout_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "workout_exercises",
                newName: "workout_exercise_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "workout_exercise_details",
                newName: "workout_exercise_detail_id");

            migrationBuilder.RenameColumn(
                name: "current_workout_id",
                table: "users",
                newName: "workout_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "users",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "programs",
                newName: "program_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "program_details",
                newName: "program_detail_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "increment_frequencies",
                newName: "increment_frequency_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_program_id",
                table: "users",
                column: "program_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_workout_id",
                table: "users",
                column: "workout_id");

            migrationBuilder.AddForeignKey(
                name: "fk_users_programs_program_id",
                table: "users",
                column: "program_id",
                principalTable: "programs",
                principalColumn: "program_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_users_workouts_workout_id",
                table: "users",
                column: "workout_id",
                principalTable: "workouts",
                principalColumn: "workout_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_users_programs_program_id",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "fk_users_workouts_workout_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_users_program_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_users_workout_id",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "workout_id",
                table: "workouts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "workout_exercise_id",
                table: "workout_exercises",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "workout_exercise_detail_id",
                table: "workout_exercise_details",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "workout_id",
                table: "users",
                newName: "current_workout_id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "program_id",
                table: "programs",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "program_detail_id",
                table: "program_details",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "increment_frequency_id",
                table: "increment_frequencies",
                newName: "id");
        }
    }
}
