using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class UpdateWorkoutExerciseDetailsIncrFreqNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_reps_increme",
                table: "workout_exercise_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_set_duration",
                table: "workout_exercise_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_weight_incre",
                table: "workout_exercise_details");

            migrationBuilder.DropColumn(
                name: "exercise",
                table: "workout_exercise_details");

            migrationBuilder.AlterColumn<int>(
                name: "weight_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "set_duration_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "reps_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_reps_increme",
                table: "workout_exercise_details",
                column: "reps_increment_frequency_id",
                principalTable: "increment_frequencies",
                principalColumn: "increment_frequency_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_set_duration",
                table: "workout_exercise_details",
                column: "set_duration_increment_frequency_id",
                principalTable: "increment_frequencies",
                principalColumn: "increment_frequency_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_weight_incre",
                table: "workout_exercise_details",
                column: "weight_increment_frequency_id",
                principalTable: "increment_frequencies",
                principalColumn: "increment_frequency_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_reps_increme",
                table: "workout_exercise_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_set_duration",
                table: "workout_exercise_details");

            migrationBuilder.DropForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_weight_incre",
                table: "workout_exercise_details");

            migrationBuilder.AlterColumn<int>(
                name: "weight_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "set_duration_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "reps_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "exercise",
                table: "workout_exercise_details",
                type: "text",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_reps_increme",
                table: "workout_exercise_details",
                column: "reps_increment_frequency_id",
                principalTable: "increment_frequencies",
                principalColumn: "increment_frequency_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_set_duration",
                table: "workout_exercise_details",
                column: "set_duration_increment_frequency_id",
                principalTable: "increment_frequencies",
                principalColumn: "increment_frequency_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_weight_incre",
                table: "workout_exercise_details",
                column: "weight_increment_frequency_id",
                principalTable: "increment_frequencies",
                principalColumn: "increment_frequency_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
