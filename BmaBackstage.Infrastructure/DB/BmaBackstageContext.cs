using BmaBackstage.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB
{
    internal class BmaBackstageContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public string DbPath { get; init; }

        public BmaBackstageContext()
        {
            var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var bmaBackstageAppdataPath = Path.Combine(appdataPath, "BmaBackstage");
            DbPath = bmaBackstageAppdataPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options
            .UseSqlite($"Data Source={DbPath}");
    }
}
