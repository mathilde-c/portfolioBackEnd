﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PortfolioBackEnd;
using System;

namespace PortfolioBackEnd.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    partial class PortfolioBackEndDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PortfolioBackEnd.Entities.Technology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Technologies");
                });

            modelBuilder.Entity("PortfolioBackEnd.Entities.TechnologyVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<string>("MajorBuild");

                    b.Property<string>("NickName");

                    b.Property<int?>("TechnologyId");

                    b.Property<DateTime>("releaseDate");

                    b.HasKey("Id");

                    b.HasIndex("TechnologyId");

                    b.ToTable("TechnologiesVersions");
                });

            modelBuilder.Entity("PortfolioBackEnd.Entities.TechnologyVersion", b =>
                {
                    b.HasOne("PortfolioBackEnd.Entities.Technology")
                        .WithMany("Versions")
                        .HasForeignKey("TechnologyId");
                });
#pragma warning restore 612, 618
        }
    }
}
