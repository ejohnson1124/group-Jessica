﻿// <auto-generated />
using System;
using HouseholdManager.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HouseholdManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HouseholdManager.Models.Household", b =>
                {
                    b.Property<int>("HouseholdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HouseholdId"), 1L, 1);

                    b.Property<string>("HouseholdName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("HouseholdId");

                    b.ToTable("Households");

                    b.HasData(
                        new
                        {
                            HouseholdId = 1,
                            HouseholdName = "DefaultHousehold",
                            Icon = ""
                        });
                });

            modelBuilder.Entity("HouseholdManager.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"), 1L, 1);

                    b.Property<int>("HouseholdId")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MemberType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.HasIndex("HouseholdId");

                    b.HasIndex("UserId");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            MemberId = 1,
                            HouseholdId = 1,
                            Icon = "👩‍🔧",
                            MemberType = "Admin",
                            UserName = "defaultAdmin@yahoo.com"
                        },
                        new
                        {
                            MemberId = 2,
                            HouseholdId = 1,
                            Icon = "👩‍💼",
                            MemberType = "Member",
                            UserName = "defaultUser@yahoo.com"
                        });
                });

            modelBuilder.Entity("HouseholdManager.Models.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MissionId"), 1L, 1);

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("MissionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("MissionId");

                    b.HasIndex("MemberId");

                    b.HasIndex("RoomId");

                    b.ToTable("Missions");

                    b.HasData(
                        new
                        {
                            MissionId = 1,
                            DueDate = new DateTime(2023, 1, 27, 9, 58, 2, 199, DateTimeKind.Local).AddTicks(554),
                            MemberId = 2,
                            MissionName = "Wash dishes",
                            Point = 2,
                            RoomId = 1
                        },
                        new
                        {
                            MissionId = 2,
                            DueDate = new DateTime(2023, 1, 27, 9, 58, 2, 199, DateTimeKind.Local).AddTicks(667),
                            MemberId = 1,
                            MissionName = "Make bed",
                            Point = 1,
                            RoomId = 5
                        },
                        new
                        {
                            MissionId = 3,
                            DueDate = new DateTime(2023, 1, 27, 9, 58, 2, 199, DateTimeKind.Local).AddTicks(679),
                            MemberId = 2,
                            MissionName = "Make bed",
                            Point = 1,
                            RoomId = 3
                        },
                        new
                        {
                            MissionId = 4,
                            DueDate = new DateTime(2023, 1, 27, 9, 58, 2, 199, DateTimeKind.Local).AddTicks(689),
                            MemberId = 1,
                            MissionName = "Mow lawn",
                            Point = 5,
                            RoomId = 9
                        },
                        new
                        {
                            MissionId = 5,
                            DueDate = new DateTime(2023, 1, 27, 9, 58, 2, 199, DateTimeKind.Local).AddTicks(697),
                            MemberId = 1,
                            MissionName = "Make dinner",
                            Point = 4,
                            RoomId = 1
                        });
                });

            modelBuilder.Entity("HouseholdManager.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"), 1L, 1);

                    b.Property<string>("Icon")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            Icon = "🥄",
                            Name = "Kitchen"
                        },
                        new
                        {
                            RoomId = 2,
                            Icon = "🧻",
                            Name = "Bathroom"
                        },
                        new
                        {
                            RoomId = 3,
                            Icon = "🛏",
                            Name = "Master Bedroom"
                        },
                        new
                        {
                            RoomId = 4,
                            Icon = "🛋",
                            Name = "Living Room"
                        },
                        new
                        {
                            RoomId = 5,
                            Icon = "🛏",
                            Name = "Bedroom"
                        },
                        new
                        {
                            RoomId = 6,
                            Icon = "🛏",
                            Name = "Guest Bedroom"
                        },
                        new
                        {
                            RoomId = 7,
                            Icon = "🧻",
                            Name = "Master Bathroom"
                        },
                        new
                        {
                            RoomId = 8,
                            Icon = "🍽",
                            Name = "Dining Room"
                        },
                        new
                        {
                            RoomId = 9,
                            Icon = "🌳",
                            Name = "Yard"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                            ConcurrencyStamp = "1",
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                            ConcurrencyStamp = "2",
                            Name = "User",
                            NormalizedName = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a1addd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "099d6d7b-8a7e-43a5-8cf1-0da39c99628d",
                            Email = "defaultAdmin@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "DEFAULTADMIN@YAHOO.COM",
                            NormalizedUserName = "DEFAULTADMIN@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELeKW1R6ys0U4t3pqRsMZgzlBxnW7EN+2WzzFPq1k6GsGbqicTqDQlYjWFqd3Tx1rw==",
                            PhoneNumber = "111-222-3333",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7fe6d526-fe7c-4e7c-894b-9ae6ac77202a",
                            TwoFactorEnabled = false,
                            UserName = "defaultAdmin@yahoo.com"
                        },
                        new
                        {
                            Id = "u1ua87c6-b718-4f48-90a2-458e0a2443e6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c1b8df6d-d480-45ea-b8f7-93eae78f06d6",
                            Email = "defaultUser@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "DEFAULTUSER@YAHOO.COM",
                            NormalizedUserName = "DEFAULTUSER@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBA1wJ+EHpEa/w4lNA9wuJWrVnF7NNhmFtrwI1xOi75EXVzdoL5ZVXeewZhEG6/3yw==",
                            PhoneNumber = "111-222-3333",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8a89dec9-741b-4fa9-a940-f191e8848c20",
                            TwoFactorEnabled = false,
                            UserName = "defaultUser@yahoo.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "a1addd14-6340-4840-95c2-db12554843e5",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "a1addd14-6340-4840-95c2-db12554843e5",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        },
                        new
                        {
                            UserId = "u1ua87c6-b718-4f48-90a2-458e0a2443e6",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HouseholdManager.Models.Member", b =>
                {
                    b.HasOne("HouseholdManager.Models.Household", "Household")
                        .WithMany()
                        .HasForeignKey("HouseholdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Household");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HouseholdManager.Models.Mission", b =>
                {
                    b.HasOne("HouseholdManager.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseholdManager.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
