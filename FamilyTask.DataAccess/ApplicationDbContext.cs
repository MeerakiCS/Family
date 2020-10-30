using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using FamilyTask.DataAccess.Data.Entities;

namespace FamilyTask.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Task> Task { get; set; }
        public DbSet<Member> Member { get; set; }
    }
}
