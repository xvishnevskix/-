using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using КурсовойПроект.Domain.Entities;
using КурсовойПроект.Models;

namespace КурсовойПроект.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "817F6C5F-3636-4120-A2EA-104449CD5834",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "B3E76A8D-5D72-4B3D-AFE3-A2E79E687F93",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@emil.ru",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty

            });

           
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "817F6C5F-3636-4120-A2EA-104449CD5834",
                UserId = "B3E76A8D-5D72-4B3D-AFE3-A2E79E687F93"

            });

            
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4428838E-BE1D-4C57-9275-98CB7DAA3294"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("B6D9259C-4053-4A5B-8EB6-47306832CF62"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });


            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("309D7FC1-5EB2-4A24-93E4-AE222692A1FB"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
