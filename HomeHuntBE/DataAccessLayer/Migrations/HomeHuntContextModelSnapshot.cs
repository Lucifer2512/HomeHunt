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
                        .HasColumnType("decimal(18, 4)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FurnitureCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalDocument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<string>("PropertyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

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
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1765),
                            Name = "Admin",
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1775)
                        },
                        new
                        {
                            Id = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1781),
                            Name = "Customer",
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1782)
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 4)");

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
                            Id = new Guid("35b94f91-9c5a-4f59-bcb9-f8a5901447a1"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1915),
                            FullName = "Admin 1",
                            Password = "m4SBywVqpxsPfkrBAMcy/6J7pdV5G7l95v47jfT8LbBRMPr9",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 786, DateTimeKind.Utc).AddTicks(1915),
                            Username = "Admin1"
                        },
                        new
                        {
                            Id = new Guid("09197de0-e732-4cd6-8c58-6516d7c02d4e"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 789, DateTimeKind.Utc).AddTicks(1635),
                            FullName = "Admin 2",
                            Password = "D1CGN7AYw/a/FnPKyrJjasDg00IPiN3lQQANdEWZsr0x3kRb",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("8f82ec39-63e6-4cd4-95d2-091a656ae301"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 789, DateTimeKind.Utc).AddTicks(1635),
                            Username = "Admin2"
                        },
                        new
                        {
                            Id = new Guid("a4bbafd8-7e20-4fb8-b1c9-d8e700b334e3"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 792, DateTimeKind.Utc).AddTicks(677),
                            FullName = "Customer 1",
                            Password = "dyyK+Su14P1K2lCKEXKjZCB5E+pgxfvDef7t7bA/qJQUbS7J",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 792, DateTimeKind.Utc).AddTicks(682),
                            Username = "Customer1"
                        },
                        new
                        {
                            Id = new Guid("e864b26a-d14d-4fdb-8fc3-b0adc132b38d"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 794, DateTimeKind.Utc).AddTicks(8697),
                            FullName = "Customer 2",
                            Password = "XeT+xB7OQnvZGXt9zvjBsVXbR4951HaaiIUVXlkImF/PYuie",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 794, DateTimeKind.Utc).AddTicks(8698),
                            Username = "Customer2"
                        },
                        new
                        {
                            Id = new Guid("161d2302-96dc-4a6a-900e-e252ff3ddff5"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 797, DateTimeKind.Utc).AddTicks(7151),
                            FullName = "Customer 3",
                            Password = "jmHghkkUIJHe+eY8mhFACjmx22Nzr5VYXgLW+WgCWr9ygA2O",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 797, DateTimeKind.Utc).AddTicks(7153),
                            Username = "Customer3"
                        },
                        new
                        {
                            Id = new Guid("86ae9865-3e9f-431d-a1a3-97280844f1ff"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 800, DateTimeKind.Utc).AddTicks(5882),
                            FullName = "Customer 4",
                            Password = "BiZvHxa6HSDsJeP4u+8VuA8clkHG5G+4YEmqkcpzev/ZYUs8",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 800, DateTimeKind.Utc).AddTicks(5882),
                            Username = "Customer4"
                        },
                        new
                        {
                            Id = new Guid("040ffc26-33a8-4ab4-b556-dc946ebe5728"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 803, DateTimeKind.Utc).AddTicks(5218),
                            FullName = "Customer 5",
                            Password = "1ltAVx/JkrMqA94ifbi+1v+5vr9JxzADks8e7ywE2RTajhZr",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 803, DateTimeKind.Utc).AddTicks(5222),
                            Username = "Customer5"
                        },
                        new
                        {
                            Id = new Guid("88d04c09-6108-45e1-8f00-3c3bafd67daa"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 806, DateTimeKind.Utc).AddTicks(3727),
                            FullName = "Customer 6",
                            Password = "Sd1Nh6fHq2OTCryH68djL7VucWEc5KOu6wZjS5yxiauCDC8V",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 806, DateTimeKind.Utc).AddTicks(3727),
                            Username = "Customer6"
                        },
                        new
                        {
                            Id = new Guid("79862b1b-05f0-456b-996d-0594afe6997f"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 809, DateTimeKind.Utc).AddTicks(3080),
                            FullName = "Customer 7",
                            Password = "06HUx3l94Ou2G5gEU0wyRD08lRtBbK8dwtDo1XsPb1fzTyYI",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 809, DateTimeKind.Utc).AddTicks(3080),
                            Username = "Customer7"
                        },
                        new
                        {
                            Id = new Guid("c1d076d5-b314-412f-a66d-1db332ee62e3"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 812, DateTimeKind.Utc).AddTicks(1151),
                            FullName = "Customer 8",
                            Password = "P4EiRrmfe5hQTy9odPM18RPiqQ459+z6bylr7ifVHWGeScgx",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 812, DateTimeKind.Utc).AddTicks(1152),
                            Username = "Customer8"
                        },
                        new
                        {
                            Id = new Guid("cc704cca-d516-42ae-8a39-69ae714aeb8a"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 814, DateTimeKind.Utc).AddTicks(9849),
                            FullName = "Customer 9",
                            Password = "9+I7PPimM6Dv8F0RN8bDFDopbu59aQdDx4pRLeTwmtL030JX",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 814, DateTimeKind.Utc).AddTicks(9849),
                            Username = "Customer9"
                        },
                        new
                        {
                            Id = new Guid("7c9244d2-83e6-42e6-8bc3-57d8d8ea75c9"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 817, DateTimeKind.Utc).AddTicks(8823),
                            FullName = "Customer 10",
                            Password = "4TtmXSMM0rhBM7kUoH/P5yyabD3sYoOyxynQZ7S/zQPeFQ1q",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 817, DateTimeKind.Utc).AddTicks(8824),
                            Username = "Customer10"
                        },
                        new
                        {
                            Id = new Guid("8307da63-c686-4c23-b6b1-1d5d8c9826ee"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 820, DateTimeKind.Utc).AddTicks(6925),
                            FullName = "Customer 11",
                            Password = "BSnviwfiEGZYHsJIdpGPimRG9DkPcAuHa9R+PkRS+cQ5UfcV",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 820, DateTimeKind.Utc).AddTicks(6926),
                            Username = "Customer11"
                        },
                        new
                        {
                            Id = new Guid("88382944-5519-4c08-9a8c-ddf9a83ff84c"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 823, DateTimeKind.Utc).AddTicks(7016),
                            FullName = "Customer 12",
                            Password = "+jAvr4xdGM0VM0bgAhCAOh7QomUZScwd05LuGfF5om7HWU7e",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 823, DateTimeKind.Utc).AddTicks(7017),
                            Username = "Customer12"
                        },
                        new
                        {
                            Id = new Guid("488f3bc8-8a9b-4c08-a3e8-4c4c7e6be936"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 826, DateTimeKind.Utc).AddTicks(5493),
                            FullName = "Customer 13",
                            Password = "lTZjoV/ISqhSdBUYq3WmMp/EGZSyrBqI7xpoBcmPcgEDy00y",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 826, DateTimeKind.Utc).AddTicks(5493),
                            Username = "Customer13"
                        },
                        new
                        {
                            Id = new Guid("f7e84332-7ae5-466d-825f-e4fb7a2f412b"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 829, DateTimeKind.Utc).AddTicks(4113),
                            FullName = "Customer 14",
                            Password = "CDb7RhGWX08nT4bV5bgk4VWXoDN0wTJrba4KMmMIoJp4tCyE",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 829, DateTimeKind.Utc).AddTicks(4114),
                            Username = "Customer14"
                        },
                        new
                        {
                            Id = new Guid("cd75d1d1-379d-4c82-b24e-9953fc81f357"),
                            CreatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 832, DateTimeKind.Utc).AddTicks(3223),
                            FullName = "Customer 15",
                            Password = "jF/iGRVbkbyipcmYj2uB1WxAokg1ytU+XQfuLcVF6u8ZqHUw",
                            PhoneNumber = "123456789",
                            RoleId = new Guid("bcadf39b-13b8-4958-8472-61f4c993fbe5"),
                            UpdatedDate = new DateTime(2024, 11, 24, 13, 3, 21, 832, DateTimeKind.Utc).AddTicks(3224),
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
                    b.HasOne("DataAccessLayer.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("transaction_userid_foreign");

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
