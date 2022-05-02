using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    public partial class InitModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "increment_frequencies",
                columns: table => new
                {
                    increment_frequency_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    frequency = table.Column<string>(type: "text", nullable: true),
                    created_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    updated_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_increment_frequencies", x => x.increment_frequency_id);
                });

            migrationBuilder.CreateTable(
                name: "program_details",
                columns: table => new
                {
                    program_detail_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sequence_num = table.Column<int>(type: "integer", nullable: false),
                    cycle_day_num = table.Column<int>(type: "integer", nullable: false),
                    created_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    updated_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    program_id = table.Column<int>(type: "integer", nullable: false),
                    workout_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_program_details", x => x.program_detail_id);
                });

            migrationBuilder.CreateTable(
                name: "programs",
                columns: table => new
                {
                    program_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    program_name = table.Column<string>(type: "text", nullable: true),
                    total_cycle_days = table.Column<int>(type: "integer", nullable: false),
                    created_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    updated_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_programs", x => x.program_id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    first_name = table.Column<string>(type: "text", nullable: true),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    date_of_birth = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    program_run = table.Column<int>(type: "integer", nullable: false),
                    created_by_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    updated_by_id = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    program_id = table.Column<int>(type: "integer", nullable: false),
                    workout_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.user_id);
                    table.ForeignKey(
                        name: "fk_users_programs_program_id",
                        column: x => x.program_id,
                        principalTable: "programs",
                        principalColumn: "program_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_users_users_created_by_id",
                        column: x => x.created_by_id,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_users_users_updated_by_id",
                        column: x => x.updated_by_id,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "workouts",
                columns: table => new
                {
                    workout_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    image_object_id = table.Column<Guid>(type: "uuid", nullable: false),
                    workout_name = table.Column<string>(type: "text", nullable: true),
                    created_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    updated_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_workouts", x => x.workout_id);
                    table.ForeignKey(
                        name: "fk_workouts_users_created_by_user_id",
                        column: x => x.created_by_user_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "fk_workouts_users_updated_by_user_id",
                        column: x => x.updated_by_user_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "workout_exercises",
                columns: table => new
                {
                    workout_exercise_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sequence_num = table.Column<int>(type: "integer", nullable: false),
                    exercise = table.Column<string>(type: "text", nullable: true),
                    created_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    updated_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    workout_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_workout_exercises", x => x.workout_exercise_id);
                    table.ForeignKey(
                        name: "fk_workout_exercises_users_created_by_user_id",
                        column: x => x.created_by_user_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "fk_workout_exercises_users_updated_by_user_id",
                        column: x => x.updated_by_user_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "fk_workout_exercises_workouts_workout_id",
                        column: x => x.workout_id,
                        principalTable: "workouts",
                        principalColumn: "workout_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "workout_exercise_details",
                columns: table => new
                {
                    workout_exercise_detail_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    set = table.Column<int>(type: "integer", nullable: false),
                    reps = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<int>(type: "integer", nullable: false),
                    set_duration = table.Column<int>(type: "integer", nullable: false),
                    set_rest_duration = table.Column<int>(type: "integer", nullable: false),
                    max_reps = table.Column<int>(type: "integer", nullable: false),
                    max_weight = table.Column<int>(type: "integer", nullable: false),
                    max_set_duration = table.Column<int>(type: "integer", nullable: false),
                    reps_increment_amount = table.Column<int>(type: "integer", nullable: false),
                    weight_increment_amount = table.Column<int>(type: "integer", nullable: false),
                    set_duration_increment_amount = table.Column<int>(type: "integer", nullable: false),
                    reps_increment_frequency_increment_frequency_id = table.Column<int>(type: "integer", nullable: true),
                    weight_increment_frequency_increment_frequency_id = table.Column<int>(type: "integer", nullable: true),
                    set_duration_increment_frequency_increment_frequency_id = table.Column<int>(type: "integer", nullable: true),
                    exercise = table.Column<string>(type: "text", nullable: true),
                    created_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    updated_by_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    workout_exercise_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_workout_exercise_details", x => x.workout_exercise_detail_id);
                    table.ForeignKey(
                        name: "fk_workout_exercise_details_increment_frequencies_reps_increme",
                        column: x => x.reps_increment_frequency_increment_frequency_id,
                        principalTable: "increment_frequencies",
                        principalColumn: "increment_frequency_id");
                    table.ForeignKey(
                        name: "fk_workout_exercise_details_increment_frequencies_set_duration",
                        column: x => x.set_duration_increment_frequency_increment_frequency_id,
                        principalTable: "increment_frequencies",
                        principalColumn: "increment_frequency_id");
                    table.ForeignKey(
                        name: "fk_workout_exercise_details_increment_frequencies_weight_incre",
                        column: x => x.weight_increment_frequency_increment_frequency_id,
                        principalTable: "increment_frequencies",
                        principalColumn: "increment_frequency_id");
                    table.ForeignKey(
                        name: "fk_workout_exercise_details_users_created_by_user_id",
                        column: x => x.created_by_user_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "fk_workout_exercise_details_users_updated_by_user_id",
                        column: x => x.updated_by_user_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "fk_workout_exercise_details_workout_exercises_workout_exercise",
                        column: x => x.workout_exercise_id,
                        principalTable: "workout_exercises",
                        principalColumn: "workout_exercise_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_increment_frequencies_created_by_user_id",
                table: "increment_frequencies",
                column: "created_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_increment_frequencies_frequency",
                table: "increment_frequencies",
                column: "frequency",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_increment_frequencies_updated_by_user_id",
                table: "increment_frequencies",
                column: "updated_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_program_details_created_by_user_id",
                table: "program_details",
                column: "created_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_program_details_program_id_workout_id",
                table: "program_details",
                columns: new[] { "program_id", "workout_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_program_details_updated_by_user_id",
                table: "program_details",
                column: "updated_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_program_details_workout_id",
                table: "program_details",
                column: "workout_id");

            migrationBuilder.CreateIndex(
                name: "ix_programs_created_by_user_id",
                table: "programs",
                column: "created_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_programs_program_name",
                table: "programs",
                column: "program_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_programs_updated_by_user_id",
                table: "programs",
                column: "updated_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_created_by_id",
                table: "users",
                column: "created_by_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_program_id",
                table: "users",
                column: "program_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_updated_by_id",
                table: "users",
                column: "updated_by_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_user_id",
                table: "users",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_users_workout_id",
                table: "users",
                column: "workout_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_created_by_user_id",
                table: "workout_exercise_details",
                column: "created_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_reps_increment_frequency_increment",
                table: "workout_exercise_details",
                column: "reps_increment_frequency_increment_frequency_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_set_duration_increment_frequency_i",
                table: "workout_exercise_details",
                column: "set_duration_increment_frequency_increment_frequency_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_updated_by_user_id",
                table: "workout_exercise_details",
                column: "updated_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_weight_increment_frequency_increme",
                table: "workout_exercise_details",
                column: "weight_increment_frequency_increment_frequency_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercise_details_workout_exercise_id_set",
                table: "workout_exercise_details",
                columns: new[] { "workout_exercise_id", "set" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_created_by_user_id",
                table: "workout_exercises",
                column: "created_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_updated_by_user_id",
                table: "workout_exercises",
                column: "updated_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_workout_id_exercise",
                table: "workout_exercises",
                columns: new[] { "workout_id", "exercise" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_workouts_created_by_user_id",
                table: "workouts",
                column: "created_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_workouts_updated_by_user_id",
                table: "workouts",
                column: "updated_by_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_workouts_workout_name",
                table: "workouts",
                column: "workout_name",
                unique: true);

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
                name: "fk_program_details_programs_program_id",
                table: "program_details",
                column: "program_id",
                principalTable: "programs",
                principalColumn: "program_id",
                onDelete: ReferentialAction.Cascade);

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
                name: "fk_program_details_workouts_workout_id",
                table: "program_details",
                column: "workout_id",
                principalTable: "workouts",
                principalColumn: "workout_id",
                onDelete: ReferentialAction.Cascade);

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
                name: "fk_programs_users_created_by_user_id",
                table: "programs");

            migrationBuilder.DropForeignKey(
                name: "fk_programs_users_updated_by_user_id",
                table: "programs");

            migrationBuilder.DropForeignKey(
                name: "fk_workouts_users_created_by_user_id",
                table: "workouts");

            migrationBuilder.DropForeignKey(
                name: "fk_workouts_users_updated_by_user_id",
                table: "workouts");

            migrationBuilder.DropTable(
                name: "program_details");

            migrationBuilder.DropTable(
                name: "workout_exercise_details");

            migrationBuilder.DropTable(
                name: "increment_frequencies");

            migrationBuilder.DropTable(
                name: "workout_exercises");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "programs");

            migrationBuilder.DropTable(
                name: "workouts");
        }
    }
}
