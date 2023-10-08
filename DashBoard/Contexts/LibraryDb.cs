﻿using DashBoard.Configurations;
using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;

namespace DashBoard.Contexts
{
    public class LibraryDb:DbContext
    {
        // functions for configuration domain classes and making connection with server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("connection_string");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new FacultyConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());
            modelBuilder.ApplyConfiguration(new LibConfig());
            modelBuilder.ApplyConfiguration(new PressConfig());
            modelBuilder.ApplyConfiguration(new T_CardConfig());
            modelBuilder.ApplyConfiguration(new S_CradConfig());
            base.OnModelCreating(modelBuilder);
        }
    
        // My Tables
        public  DbSet<Book> Book { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Lib> Libs { get; set; }

        public DbSet<Press> Presses { get; set; }

        public DbSet<S_Card> S_Cards { get; set; }

        public DbSet<T_Card> T_Cards { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Theme> Themes { get; set; }
    }

}
