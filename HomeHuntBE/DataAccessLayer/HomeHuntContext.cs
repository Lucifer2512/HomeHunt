
using System;
using System.Collections.Generic;
using DataAccessLayer.Models;
using DataAccessLayer.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer;

public class HomeHuntContext : DbContext
{
    public HomeHuntContext()
    {
    }

    public HomeHuntContext(DbContextOptions<HomeHuntContext> options) : base(options)
    {
    }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
    }

    private string? GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
        return configuration.GetConnectionString("Local");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("post_id_primary");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.ToTable("Post");
            entity.Property(e => e.RentPrice)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Deposit)
                .HasColumnType("decimal(18, 2)");
            entity.HasOne(d => d.User).WithMany(p => p.Posts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("post_userid_foreign");
            entity.HasOne(d => d.Transaction).WithOne(p => p.Post)
                .HasForeignKey<Transaction>(t => t.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("post_transactionid_foreign");

        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("transaction_id_primary");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.ToTable("Transaction");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)");
            entity.HasOne(d => d.User).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_userid_foreign");

        });


        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("role_id_primary");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.ToTable("Role");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);

        });


        modelBuilder.Entity<User>(entity =>
        {
            base.OnModelCreating(modelBuilder);

            entity.HasKey(e => e.Id).HasName("user_id_primary");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.ToTable("User");

            entity.Property(e => e.Address)
                .HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dob).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(255);
            entity.HasIndex(e => e.Email).IsUnique().HasDatabaseName("user_email_unique");
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(255);
            entity.HasIndex(e => e.Username).IsUnique().HasDatabaseName("user_Username_unique");
            entity.Property(e => e.Gender)
                .HasMaxLength(255);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_roleid_foreign");
        });

        Guid adminRoleId = new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301");
        Guid customerRoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5");
        Guid tempRoomId = new Guid("1b9cbb78-8942-4783-8e26-b19e8e7e98c8");

        modelBuilder.Entity<Role>().HasData(
            new Role { Id = adminRoleId, Name = "Admin" },
            new Role { Id = customerRoleId, Name = "Customer" }
        );

        // Seeding users with the appropriate RoleId
        modelBuilder.Entity<User>().HasData(
            new User { Id = Guid.NewGuid(), Username = "Admin", FullName = "Admin ", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = adminRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Admin2", FullName = "Admin 2", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = adminRoleId },
            new User { Id = Guid.NewGuid(), Username = "Customer", FullName = "Customer ", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId }
            //new User { Id = Guid.NewGuid(), Username = "Customer2", FullName = "Customer 2", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer3", FullName = "Customer 3", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer4", FullName = "Customer 4", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer5", FullName = "Customer 5", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer6", FullName = "Customer 6", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer7", FullName = "Customer 7", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer8", FullName = "Customer 8", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer9", FullName = "Customer 9", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer10", FullName = "Customer 10", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer11", FullName = "Customer 11", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer12", FullName = "Customer 12", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer13", FullName = "Customer 13", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer14", FullName = "Customer 14", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId },
            //new User { Id = Guid.NewGuid(), Username = "Customer15", FullName = "Customer 15", Password = PasswordTools.HashPassword("123456"), PhoneNumber = "123456789", RoleId = customerRoleId }
        );
    }

}