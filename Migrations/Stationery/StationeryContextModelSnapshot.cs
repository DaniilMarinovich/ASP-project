﻿// <auto-generated />
using ASPLAB_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPLAB_2.Migrations.Stationery
{
    [DbContext(typeof(StationeryContext))]
    partial class StationeryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASPLAB_2.Models.Stationery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stationeries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pen",
                            Type = "sdf"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pensil",
                            Type = "sdf"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Сopybook",
                            Type = "sdf"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
