using System;
using System.Collections.Generic;
using StrengthifyNETAPI.Models;

namespace StrengthifyNETAPI.Tests
{
    public static class Utilities
    {
        public static void InitializeDbForTests(StrengthifyContext db)
        {
            db.Users.AddRange(GetSeedingMessages());
            db.SaveChanges();
        }

        public static void ReinitializeDbForTests(StrengthifyContext db)
        {
            db.Users.RemoveRange(db.Users);
            InitializeDbForTests(db);
        }

        public static List<User> GetSeedingMessages()
        {
            return new List<User>()
            {
                new User() {
                    Uuid = new Guid("29ed5754-b19a-41fb-a902-6503717850a1"),
                    FirstName = "Admin1",
                    LastName = "Admin1",
                    DateOfBirth = new DateTime(1994, 02, 03),
                    Email = "admin1@admin.com",
                    ProgramRun = 0,
                    ProgramId = 0
                },
                new User() {
                    Uuid = new Guid("29ed5754-b19a-41fb-a902-6503717850a2"),
                    FirstName = "Admin2",
                    LastName = "Admin2",
                    DateOfBirth = new DateTime(1994, 02, 03),
                    Email = "admin2@admin.com",
                    ProgramRun = 0,
                    ProgramId = 0
                },
                new User() {
                    Uuid = new Guid("29ed5754-b19a-41fb-a902-6503717850a3"),
                    FirstName = "Admin3",
                    LastName = "Admin3",
                    DateOfBirth = new DateTime(1994, 02, 03),
                    Email = "admin3@admin.com",
                    ProgramRun = 0,
                    ProgramId = 0
                },
            };
        }
    }
}