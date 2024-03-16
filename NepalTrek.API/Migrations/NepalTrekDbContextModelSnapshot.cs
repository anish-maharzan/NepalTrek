﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NepalTrek.API.Data;

#nullable disable

namespace NepalTrek.API.Migrations
{
    [DbContext(typeof(NepalTrekDbContext))]
    partial class NepalTrekDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NepalTrek.API.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("96458856-4c06-4885-8e74-858340ef700e"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("20ce24f5-2c3b-4054-993d-5f50e4d842a3"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("9ecb8c2e-01e5-443c-aef3-46b00a4077c0"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("NepalTrek.API.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("NepalTrek.API.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ffc0b296-6648-4aab-9dc3-4af94ef23dd0"),
                            Code = "ABC",
                            Name = "Annapurna Base Camp",
                            RegionImageUrl = "https://www.marveladventure.com/uploads/editors/Annapurna-Base-Camp-Trek-in-January-and-February-1.jpg"
                        },
                        new
                        {
                            Id = new Guid("eaf3f13e-a9ba-4b61-abf5-12e1bddc7e7c"),
                            Code = "EBC",
                            Name = "Everest Base Camp",
                            RegionImageUrl = "https://worldalpinetreks.com/uploads/2022/11/everest-base-camp-short-trek-scaled-e1641875466943.jpg"
                        },
                        new
                        {
                            Id = new Guid("9cc9aabe-887d-42dc-abc5-d01051ef1be9"),
                            Code = "LVT",
                            Name = "Langtang Valley Trek",
                            RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.magicalsummits.com%2Flangtang-valley-trek%2F&psig=AOvVaw0b8m52a_8I4LgEhEw2Hvyg&ust=1710485873372000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCMDy8cqW84QDFQAAAAAdAAAAABAE"
                        },
                        new
                        {
                            Id = new Guid("1c9aa80b-846c-42cd-a86b-af91cb3d22a0"),
                            Code = "MCT",
                            Name = "Manaslu Circuit Trek",
                            RegionImageUrl = "https://www.nepalfootprintholiday.com/wp-content/uploads/2022/06/manaslu-trek-photo.webp"
                        },
                        new
                        {
                            Id = new Guid("4a44a12c-4ecc-44ad-9576-5b87d4c88776"),
                            Code = "MBC",
                            Name = "Machhapuchhare Base Camp",
                            RegionImageUrl = "https://www.environmentaltrekking.com/public/uploads/machhapuchhre-base-camp-trek1.jpg"
                        });
                });

            modelBuilder.Entity("NepalTrek.API.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("NepalTrek.API.Models.Domain.Walk", b =>
                {
                    b.HasOne("NepalTrek.API.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NepalTrek.API.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
