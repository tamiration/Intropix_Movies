﻿// <auto-generated />
using System;
using Intropix_Movies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Intropix_Movies.Migrations
{
    [DbContext(typeof(Intropix_MoviesContext))]
    partial class Intropix_MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Intropix_Movies.Models.Studio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<int>("Year_of_foundation");

                    b.HasKey("ID");

                    b.ToTable("Studio");
                });

            modelBuilder.Entity("Intropix_Movies.Models.Trailers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Lat");

                    b.Property<int>("Lenght");

                    b.Property<double>("Lon");

                    b.Property<string>("Name");

                    b.Property<int>("Rating");

                    b.Property<string>("Source_link");

                    b.Property<int>("Studio_id");

                    b.Property<string>("Summary");

                    b.HasKey("ID");

                    b.ToTable("Trailers");
                });

            modelBuilder.Entity("Intropix_Movies.Models.Views_List", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("movie_id");

                    b.Property<DateTime>("timestamp");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("Views_List");
                });
#pragma warning restore 612, 618
        }
    }
}
