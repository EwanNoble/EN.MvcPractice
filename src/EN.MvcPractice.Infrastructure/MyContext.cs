using EN.MvcPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace EN.MvcPractice.Infrastructure
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options) { }

        public DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Title>()
                .Property(e => e.TitleColor)
                .HasConversion(
                    v => v.ToArgb(),
                    v => Color.FromArgb(v));

            modelBuilder
                .Entity<Title>()
                .HasData(
                    new Title { Id = 1, TitleColor = Color.Black, TitleSize = 18, TitleText = "Homepage" });

            base.OnModelCreating(modelBuilder);
        }
    }
}
