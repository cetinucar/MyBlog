using Common.Security;
using Microsoft.EntityFrameworkCore;
using MyBlog.DAL.Config;
using MyBlog.Domain.Entities;
using MyBlog.Domain.Enums;
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


            modelBuilder.Entity<User>().HasData(new User
            {
                Id=1,
                UserName="cetinnucar@gmail.com",
                 Email= "cetinnucar@gmail.com",
                 PasswordHash=HashHelper.HashPassword("Ankara1."),
                 UserType=UserType.Admin

            });
        }


        DbSet<Category> Categories { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<Post> Posts { get; set; }

    }
}
