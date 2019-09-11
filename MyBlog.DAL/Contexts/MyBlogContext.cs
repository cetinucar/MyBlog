using Microsoft.EntityFrameworkCore;
using MyBlog.DAL.Config;
using MyBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DAL.Contexts
{
    class MyBlogContext : DbContext
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {
            //Veritabanının oluşturulduğundan emin ol
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }


        DbSet<Category> Categories { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<Post> Posts { get; set; }

    }
}
