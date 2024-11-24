﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(HomeHuntContext))]
    partial class HomeHuntContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLayer.Models.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApartmentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bathrooms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bedrooms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Block")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Deposit")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FurnitureCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalDocument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RentPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid?>("TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("post_id_primary");

                    b.HasIndex("UserId");

                    b.ToTable("Post", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("role_id_primary");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2231),
                            Name = "Admin",
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2240)
                        },
                        new
                        {
                            Id = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2244),
                            Name = "Customer",
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2244)
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TransactionCode")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("transaction_id_primary");

                    b.HasIndex("PostId")
                        .IsUnique()
                        .HasFilter("[PostId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("Transaction", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Gender")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id")
                        .HasName("user_id_primary");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("user_email_unique")
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("user_Username_unique");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5a74f9e4-3358-45db-958f-37b58b3255e3"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2402),
                            FullName = "Admin 1",
                            Password = "eoYOJ66vJAgFTXisR4XubpyJN30P5k9NuFVgBeoWHYXizuxi",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 114, DateTimeKind.Utc).AddTicks(2402),
                            Username = "Admin1"
                        },
                        new
                        {
                            Id = new Guid("99cd22b8-fa62-41f5-9a6f-05a1d60d431c"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 117, DateTimeKind.Utc).AddTicks(2974),
                            FullName = "Admin 2",
                            Password = "Bcvpw/jUZthtQbo8X9uQl09llI/m/lZCPnckZ9N5D0cfkrNt",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 117, DateTimeKind.Utc).AddTicks(2974),
                            Username = "Admin2"
                        },
                        new
                        {
                            Id = new Guid("32835ef7-d7ab-4c7c-88a8-f4fd40d75dad"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 120, DateTimeKind.Utc).AddTicks(4107),
                            FullName = "Customer 1",
                            Password = "aWhkUoP7OEybXwQGwpjycbWp4HTnz2KfqdYBnMtTFkzm582l",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 120, DateTimeKind.Utc).AddTicks(4111),
                            Username = "Customer1"
                        },
                        new
                        {
                            Id = new Guid("43c46811-0b29-4c91-8eff-a67369a5ca8d"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 123, DateTimeKind.Utc).AddTicks(4151),
                            FullName = "Customer 2",
                            Password = "wsfS5lgqFHdRKDeA87Z0QY/kKBHIcpQ/gggEC9riFovVbMig",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 123, DateTimeKind.Utc).AddTicks(4152),
                            Username = "Customer2"
                        },
                        new
                        {
                            Id = new Guid("e9ea8474-ca77-487d-9f56-2f9b63cd8db9"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 126, DateTimeKind.Utc).AddTicks(4224),
                            FullName = "Customer 3",
                            Password = "AlAsDCTnNTbhk9OnSNNnusM0DMJeIz3suyOsSL+8yjp13p4b",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 126, DateTimeKind.Utc).AddTicks(4224),
                            Username = "Customer3"
                        },
                        new
                        {
                            Id = new Guid("2845c934-4532-420d-8b79-87f0a2af8954"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 129, DateTimeKind.Utc).AddTicks(4729),
                            FullName = "Customer 4",
                            Password = "0BKpTMwHjRnQloifd31lTJGmFdT8jjXS2Y1vQRT8IlWwpce9",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 129, DateTimeKind.Utc).AddTicks(4730),
                            Username = "Customer4"
                        },
                        new
                        {
                            Id = new Guid("ecd1be51-2688-4acb-8794-6e73d15533a9"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 132, DateTimeKind.Utc).AddTicks(7311),
                            FullName = "Customer 5",
                            Password = "tkyEahq4NeRJ4hzc50Zh+m3nYf2HfDkhRPwMK7a4+1p9ER8v",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 132, DateTimeKind.Utc).AddTicks(7326),
                            Username = "Customer5"
                        },
                        new
                        {
                            Id = new Guid("7777a24a-4b2e-4b7e-b14c-2c066dab0b53"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 135, DateTimeKind.Utc).AddTicks(7184),
                            FullName = "Customer 6",
                            Password = "jHg+s47EpYXNGlGuuomlZlMykMoewG6QoK2EG5/jdjASUkYl",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 135, DateTimeKind.Utc).AddTicks(7184),
                            Username = "Customer6"
                        },
                        new
                        {
                            Id = new Guid("f1ba2a9e-d38d-4fc5-b9f8-2cf6e321ef3f"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 138, DateTimeKind.Utc).AddTicks(7517),
                            FullName = "Customer 7",
                            Password = "Jz+LqjeOaxFvWLAnd51ysI74RM/fiQbl43x44LkTu8C4jqSL",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 138, DateTimeKind.Utc).AddTicks(7518),
                            Username = "Customer7"
                        },
                        new
                        {
                            Id = new Guid("a88fc8d0-7f69-4c04-815d-0562d552dc64"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 141, DateTimeKind.Utc).AddTicks(8238),
                            FullName = "Customer 8",
                            Password = "uG5Tx8PGtpnLCh8j+wvNKGMF8brEXapOm446TLlSkx/WP5L8",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 141, DateTimeKind.Utc).AddTicks(8239),
                            Username = "Customer8"
                        },
                        new
                        {
                            Id = new Guid("503ddd69-0f19-4b48-92de-c8e15a0e9e1d"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 144, DateTimeKind.Utc).AddTicks(9694),
                            FullName = "Customer 9",
                            Password = "DvlNh82CPRcw2d4Xp/qmN3uz1h++GWiBr+AEzSi2zO9NEMj2",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 144, DateTimeKind.Utc).AddTicks(9702),
                            Username = "Customer9"
                        },
                        new
                        {
                            Id = new Guid("092be2a9-c8f5-4972-b1d2-fb110af8f029"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 148, DateTimeKind.Utc).AddTicks(213),
                            FullName = "Customer 10",
                            Password = "StuDtkRqfLWgTVg6iBw4Ra9eLrAp2ZabelKznpIho2/29YOh",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 148, DateTimeKind.Utc).AddTicks(213),
                            Username = "Customer10"
                        },
                        new
                        {
                            Id = new Guid("fc384321-75b7-497c-a5d5-7a66052233f3"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 151, DateTimeKind.Utc).AddTicks(359),
                            FullName = "Customer 11",
                            Password = "BIK5jxW3614ojWFsn5VANXCu9ZFPjjy9kbYnk6No2kcR+lJa",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 151, DateTimeKind.Utc).AddTicks(360),
                            Username = "Customer11"
                        },
                        new
                        {
                            Id = new Guid("fde6ab79-7c76-449e-ae4d-032acaea96ec"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 154, DateTimeKind.Utc).AddTicks(464),
                            FullName = "Customer 12",
                            Password = "GI8z2RW0zclf5zWTf1pbcJg4yMMMrRL4YlEVjILewHtx5Kjl",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 154, DateTimeKind.Utc).AddTicks(464),
                            Username = "Customer12"
                        },
                        new
                        {
                            Id = new Guid("4af09939-9312-4521-8780-8d49f1e9ccd4"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 157, DateTimeKind.Utc).AddTicks(603),
                            FullName = "Customer 13",
                            Password = "0jhZ76kEGUOjTjBXRDRT8YbXzuwY9924ENBKzn8dRdUhzLzt",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 157, DateTimeKind.Utc).AddTicks(604),
                            Username = "Customer13"
                        },
                        new
                        {
                            Id = new Guid("c844df94-fca8-430e-a778-bd30777b671e"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 160, DateTimeKind.Utc).AddTicks(1434),
                            FullName = "Customer 14",
                            Password = "UcRrM2NRXNrS7pfQRrQi5UpyTgmNIFP9LQ7+Y/gdnviY42qb",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 160, DateTimeKind.Utc).AddTicks(1435),
                            Username = "Customer14"
                        },
                        new
                        {
                            Id = new Guid("898d9a28-7f48-4bc6-8ead-2890f7993d42"),
                            CreatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 163, DateTimeKind.Utc).AddTicks(1769),
                            FullName = "Customer 15",
                            Password = "7PZnNsUcasVc+8svy+jtreeq6dP31n387EBr4JJ1VOx8GDhk",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 23, 6, 42, 163, DateTimeKind.Utc).AddTicks(1769),
                            Username = "Customer15"
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Post", b =>
                {
                    b.HasOne("DataAccessLayer.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("post_userid_foreign");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Transaction", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Post", "Post")
                        .WithOne("Transaction")
                        .HasForeignKey("DataAccessLayer.Models.Transaction", "PostId")
                        .HasConstraintName("post_transactionid_foreign");

                    b.HasOne("DataAccessLayer.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("transaction_userid_foreign");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccessLayer.Models.User", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("user_roleid_foreign");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Post", b =>
                {
                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DataAccessLayer.Models.User", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
