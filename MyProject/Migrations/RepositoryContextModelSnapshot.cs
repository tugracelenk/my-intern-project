﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyProject.Models;

#nullable disable

namespace MyProject.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("MyProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bilim Kurgu"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aksiyon"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Korku"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Komedi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Romantik"
                        });
                });

            modelBuilder.Entity("MyProject.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kadikoy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Besiktas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bahcelievler"
                        });
                });

            modelBuilder.Entity("MyProject.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DistrictId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Rating")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DistrictId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Bu bir aciklama metnidir.",
                            DistrictId = 1,
                            Name = "Yildizlar Arasi",
                            Rating = 4.1f
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 4,
                            Description = "Bu bir aciklama metnidir.",
                            DistrictId = 3,
                            Name = "Recep Ivedik",
                            Rating = 4.8f
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Bu bir aciklama metnidir.",
                            DistrictId = 1,
                            Name = "Recep Ivedik",
                            Rating = 3.2f
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Bu bir aciklama metnidir.",
                            DistrictId = 1,
                            Name = "Tasiyici",
                            Rating = 4.9f
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Bu bir aciklama metnidir.",
                            DistrictId = 3,
                            Name = "Tasiyici",
                            Rating = 5f
                        });
                });

            modelBuilder.Entity("MyProject.Models.Movie", b =>
                {
                    b.HasOne("MyProject.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyProject.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("District");
                });
#pragma warning restore 612, 618
        }
    }
}
