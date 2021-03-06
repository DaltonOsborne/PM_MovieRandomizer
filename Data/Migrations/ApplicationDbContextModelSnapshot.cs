// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PM_MovieRandomizer.Data;

#nullable disable

namespace PM_MovieRandomizer.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

            modelBuilder.Entity("PM_MovieRandomizer.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("OpeningWeekendSales")
                        .HasColumnType("float");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f11ddda7-bb09-4d47-8da6-26f2065f15c8"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(1998, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pokemon: The First Movie"
                        },
                        new
                        {
                            Id = new Guid("787d31a1-9ef9-4878-a5a7-05bcbead08d4"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2014, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Diancie and the Coccoon of Destruction"
                        },
                        new
                        {
                            Id = new Guid("9b81b94a-b349-416a-bf6a-1e0ee522af0b"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2012, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Kyruem vs.the Sword of Justice"
                        },
                        new
                        {
                            Id = new Guid("05fcfd45-9640-44e5-a9c8-474771bb0f0d"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Mewtwo Strikes Back:Evolution"
                        },
                        new
                        {
                            Id = new Guid("0b563a12-95fe-4b3b-b064-2b313d9e8fad"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(1999, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pokemon:The Movie 2000"
                        },
                        new
                        {
                            Id = new Guid("0f01cf4c-ada8-47bf-851c-54511fcc9452"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2013, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Genesect and the Legend Awakened"
                        },
                        new
                        {
                            Id = new Guid("78b7ee83-de99-4c18-bdcd-e51509fba783"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2003, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Jirachi—Wish Maker"
                        },
                        new
                        {
                            Id = new Guid("f92ee42d-59c3-49a5-a0ca-54ba1e15fe80"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2001, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pokémon 4Ever: Celebi - Voice of the Forest"
                        },
                        new
                        {
                            Id = new Guid("c4d62c29-2e5c-44ba-abc2-54ca990f1f89"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2017, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "I Choose You!"
                        },
                        new
                        {
                            Id = new Guid("6da8557d-a8ee-4007-8f3f-589e11774875"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2000, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pokémon 3: The Movie - Spell of the Unown"
                        },
                        new
                        {
                            Id = new Guid("00463795-12f5-43cf-8d5f-6625f923b0c0"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2007, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Rise of Darkrai"
                        },
                        new
                        {
                            Id = new Guid("e8a299e3-c2e2-43bd-bed6-67535548fcca"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2018, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Power of Us"
                        },
                        new
                        {
                            Id = new Guid("3b4ea11f-d809-4171-85c9-69689bd4590c"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2009, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Arceus and the Jewel of Life"
                        },
                        new
                        {
                            Id = new Guid("ce40dcbe-9c39-4705-8d47-731597dfd50e"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2010, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Zoroark--Master of Illusions"
                        },
                        new
                        {
                            Id = new Guid("faf5bb2f-33c6-495c-b179-76a72f119781"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2002, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pokémon Heroes: Latios and Latias"
                        },
                        new
                        {
                            Id = new Guid("984a54c7-a77e-4170-abbe-93c0f10a4473"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2015, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hoopa and the Clash of Ages"
                        },
                        new
                        {
                            Id = new Guid("e5464945-4a65-4fec-8b66-a945497238df"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Secrets of the Jungle"
                        },
                        new
                        {
                            Id = new Guid("e48c1456-5e27-4304-9bae-b3e18045811d"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2006, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pokemon Ranger and the Temple of the Sea"
                        },
                        new
                        {
                            Id = new Guid("9cf5db30-ee2b-449c-9932-b4a1f416416c"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2004, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Destiny Deoxys"
                        },
                        new
                        {
                            Id = new Guid("ab8c3688-d543-4da2-b99c-c2c8d62f3507"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2008, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Giratina and the Sky Warrior"
                        },
                        new
                        {
                            Id = new Guid("e7e25a3f-a394-4ab4-90db-dc9842bc8c47"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2005, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Lucario and the Mystery of Mew"
                        },
                        new
                        {
                            Id = new Guid("fe92db7f-1a35-4bca-97ee-de59b25b5111"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2011, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Black--Victini and Reshiram"
                        },
                        new
                        {
                            Id = new Guid("ec4a1ebe-a63f-4f53-afac-f40cef1d6f5b"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Volcanion and the Mechanical Marvel"
                        },
                        new
                        {
                            Id = new Guid("e9a4eba3-da09-40b9-8a2e-f7558a240d23"),
                            OpeningWeekendSales = 345345345.0,
                            Rating = 0,
                            ReleaseDate = new DateTime(2011, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "White--Victini and Zekrom"
                        });
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
