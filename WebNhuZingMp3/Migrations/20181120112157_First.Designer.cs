﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebNhuZingMp3.Models;

namespace WebNhuZingMp3.Migrations
{
    [DbContext(typeof(WebNhuZingMp3Context))]
    [Migration("20181120112157_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebNhuZingMp3.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Link");

                    b.Property<string>("Singer");

                    b.Property<string>("SongName");

                    b.Property<string>("Thumbnail");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("SongId");

                    b.ToTable("Song");
                });
#pragma warning restore 612, 618
        }
    }
}