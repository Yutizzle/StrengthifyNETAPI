using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class UpdateWorkoutExerciseDetailIncrementFreqIdRelationship : Migration
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

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_reps_increment_frequency_increment",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_set_duration_increment_frequency_i",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_weight_increment_frequency_increme",
                table: "workout_exercise_details");

            migrationBuilder.DropColumn(
                name: "reps_increment_frequency_increment_frequency_id",
                table: "workout_exercise_details");

            migrationBuilder.DropColumn(
                name: "set_duration_increment_frequency_increment_frequency_id",
                table: "workout_exercise_details");

            migrationBuilder.DropColumn(
                name: "weight_increment_frequency_increment_frequency_id",
                table: "workout_exercise_details");

            migrationBuilder.AddColumn<int>(
                name: "reps_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "set_duration_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "weight_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_reps_increment_frequency_id",
                table: "workout_exercise_details",
                column: "reps_increment_frequency_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_set_duration_increment_frequency_id",
                table: "workout_exercise_details",
                column: "set_duration_increment_frequency_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_weight_increment_frequency_id",
                table: "workout_exercise_details",
                column: "weight_increment_frequency_id");

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

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_reps_increment_frequency_id",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_set_duration_increment_frequency_id",
                table: "workout_exercise_details");

            migrationBuilder.DropIndex(
                name: "ix_workout_exercise_details_weight_increment_frequency_id",
                table: "workout_exercise_details");

            migrationBuilder.DropColumn(
                name: "reps_increment_frequency_id",
                table: "workout_exercise_details");

            migrationBuilder.DropColumn(
                name: "set_duration_increment_frequency_id",
                table: "workout_exercise_details");

            migrationBuilder.DropColumn(
                name: "weight_increment_frequency_id",
                table: "workout_exercise_details");

            migrationBuilder.AddColumn<int>(
                name: "reps_increment_frequency_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "set_duration_increment_frequency_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "weight_increment_frequency_increment_frequency_id",
                table: "workout_exercise_details",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_reps_increment_frequency_increment",
                table: "workout_exercise_details",
                column: "reps_increment_frequency_increment_frequency_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_set_duration_increment_frequency_i",
                table: "workout_exercise_details",
                column: "set_duration_increment_frequency_increment_frequency_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_weight_increment_frequency_increme",
                table: "workout_exercise_details",
                column: "weight_increment_frequency_increment_frequency_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_reps_increme",
                table: "workout_exercise_details",
                column: "reps_increment_frequency_increment_frequency_id",
                principalTable: "increment_frequencies",
                principalColumn: "increment_frequency_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_set_duration",
                table: "workout_exercise_details",
                column: "set_duration_increment_frequency_increment_frequency_id",
                principalTable: "increment_frequencies",
                principalColumn: "increment_frequency_id");

            migrationBuilder.AddForeignKey(
                name: "fk_workout_exercise_details_increment_frequencies_weight_incre",
                table: "workout_exercise_details",
                column: "weight_increment_frequency_increment_frequency_id",
                principalTable: "increment_frequencies",
                principalColumn: "increment_frequency_id");
        }
    }
}
