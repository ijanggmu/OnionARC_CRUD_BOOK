using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;

namespace OA.Repo
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new BookMap(modelBuilder.Entity<BookList>());
            new StudentMap(modelBuilder.Entity<StudentList>());
        }
    }
}
