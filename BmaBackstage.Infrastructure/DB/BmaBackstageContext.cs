using BmaBackstage.Infrastructure.DB.DataModel;
using BmaBackstage.Infrastructure.DB.DataModel.People;
using BmaBackstage.Infrastructure.DB.DataModel.Progressions;
using BmaBackstage.Infrastructure.DB.DataModel.Progressions.Requirements;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB
{
    public class BmaBackstageContext : DbContext
    {
        public DbSet<TimeSheetEntry> TimeSheetEntries { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentContract> Contracts { get; set; }

        public DbSet<EmergencyContact> EmergencyContacts { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<Progression> Progressions { get; set; }

        public DbSet<ProgressionStage> ProgressionStages { get; set; }

        public DbSet<AgeRequirement> AgeRequirements { get; set; }

        public DbSet<AttendanceRequirement> AttendanceRequirements { get; set; }

        public DbSet<ManualApprovalRequirement> ManualApprovalRequirements { get; set; }

        public string DbPath { get; init; }

        public BmaBackstageContext()
        {
            var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var bmaBackstageAppdataPath = Path.Combine(appdataPath, "BmaBackstage/BmaBackstage.db");
            DbPath = bmaBackstageAppdataPath;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite($"Data Source={DbPath}");
            }
        }
    }
}
