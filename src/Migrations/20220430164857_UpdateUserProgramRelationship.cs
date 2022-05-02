using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class UpdateUserProgramRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_users_programs_program_id",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "fk_users_workouts_workout_id",
                table: "users");

            migrationBuilder.AlterColumn<int>(
                name: "workout_id",
                table: "users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "program_id",
                table: "users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "fk_users_programs_program_id",
                table: "users",
                column: "program_id",
                principalTable: "programs",
                principalColumn: "program_id");

            migrationBuilder.AddForeignKey(
                name: "fk_users_workouts_workout_id",
                table: "users",
                column: "workout_id",
                principalTable: "workouts",
                principalColumn: "workout_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_users_programs_program_id",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "fk_users_workouts_workout_id",
                table: "users");

            migrationBuilder.AlterColumn<int>(
                name: "workout_id",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "program_id",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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
    }
}
