﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Strengthify;

#nullable disable

namespace StrengthifyNETAPI.Migrations
{
    [DbContext(typeof(StrengthifyContext))]
    [Migration("20220424235213_AddLookupTables")]
    partial class AddLookupTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Strengthify.Models.IncrementFrequency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<string>("Frequency")
                        .HasColumnType("text")
                        .HasColumnName("frequency");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_increment_frequencies");

                    b.ToTable("increment_frequencies", (string)null);
                });

            modelBuilder.Entity("Strengthify.Models.Program", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<string>("ProgramName")
                        .HasColumnType("text")
                        .HasColumnName("program_name");

                    b.Property<int>("TotalCycleDays")
                        .HasColumnType("integer")
                        .HasColumnName("total_cycle_days");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_programs");

                    b.ToTable("programs", (string)null);
                });

            modelBuilder.Entity("Strengthify.Models.ProgramDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<int>("CycleDayNum")
                        .HasColumnType("integer")
                        .HasColumnName("cycle_day_num");

                    b.Property<int>("ProgramId")
                        .HasColumnType("integer")
                        .HasColumnName("program_id");

                    b.Property<int>("SequenceNum")
                        .HasColumnType("integer")
                        .HasColumnName("sequence_num");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("integer")
                        .HasColumnName("workout_id");

                    b.HasKey("Id")
                        .HasName("pk_program_details");

                    b.ToTable("program_details", (string)null);
                });

            modelBuilder.Entity("Strengthify.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<int>("CurrentWorkoutId")
                        .HasColumnType("integer")
                        .HasColumnName("current_workout_id");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<int>("ProgramId")
                        .HasColumnType("integer")
                        .HasColumnName("program_id");

                    b.Property<int>("ProgramRun")
                        .HasColumnType("integer")
                        .HasColumnName("program_run");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uuid")
                        .HasColumnName("uuid");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Strengthify.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<Guid>("ImageObjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("image_object_id");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.Property<string>("WorkoutName")
                        .HasColumnType("text")
                        .HasColumnName("workout_name");

                    b.HasKey("Id")
                        .HasName("pk_workouts");

                    b.ToTable("workouts", (string)null);
                });

            modelBuilder.Entity("Strengthify.Models.WorkoutExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<string>("Exercise")
                        .HasColumnType("text")
                        .HasColumnName("exercise");

                    b.Property<int>("SequenceNum")
                        .HasColumnType("integer")
                        .HasColumnName("sequence_num");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("integer")
                        .HasColumnName("workout_id");

                    b.HasKey("Id")
                        .HasName("pk_workout_exercises");

                    b.ToTable("workout_exercises", (string)null);
                });

            modelBuilder.Entity("Strengthify.Models.WorkoutExerciseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<string>("Exercise")
                        .HasColumnType("text")
                        .HasColumnName("exercise");

                    b.Property<int>("MaxReps")
                        .HasColumnType("integer")
                        .HasColumnName("max_reps");

                    b.Property<int>("MaxSetDuration")
                        .HasColumnType("integer")
                        .HasColumnName("max_set_duration");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("integer")
                        .HasColumnName("max_weight");

                    b.Property<int>("Reps")
                        .HasColumnType("integer")
                        .HasColumnName("reps");

                    b.Property<int>("RepsIncrementAmount")
                        .HasColumnType("integer")
                        .HasColumnName("reps_increment_amount");

                    b.Property<int>("RepsIncrementFrequencyId")
                        .HasColumnType("integer")
                        .HasColumnName("reps_increment_frequency_id");

                    b.Property<int>("Set")
                        .HasColumnType("integer")
                        .HasColumnName("set");

                    b.Property<int>("SetDuration")
                        .HasColumnType("integer")
                        .HasColumnName("set_duration");

                    b.Property<int>("SetDurationIncrementAmount")
                        .HasColumnType("integer")
                        .HasColumnName("set_duration_increment_amount");

                    b.Property<int>("SetDurationIncrementFrequencyId")
                        .HasColumnType("integer")
                        .HasColumnName("set_duration_increment_frequency_id");

                    b.Property<int>("SetRestDuration")
                        .HasColumnType("integer")
                        .HasColumnName("set_rest_duration");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.Property<int>("Weight")
                        .HasColumnType("integer")
                        .HasColumnName("weight");

                    b.Property<int>("WeightIncrementAmount")
                        .HasColumnType("integer")
                        .HasColumnName("weight_increment_amount");

                    b.Property<int>("WeightIncrementFrequencyId")
                        .HasColumnType("integer")
                        .HasColumnName("weight_increment_frequency_id");

                    b.Property<int>("WorkoutExerciseId")
                        .HasColumnType("integer")
                        .HasColumnName("workout_exercise_id");

                    b.HasKey("Id")
                        .HasName("pk_workout_exercise_details");

                    b.ToTable("workout_exercise_details", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
