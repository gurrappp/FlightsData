﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCSA.WebAPIs.FlightsData.Data;

#nullable disable

namespace TCSA.WebAPIs.FlightsData.Data.Migrations
{
    [DbContext(typeof(FlightsDbContext))]
    partial class FlightsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("TCSA.WebAPIs.FlightsData.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AirlineName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArrivalAirportCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ArrivalDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartureAirportCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("FlightNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassengerCapacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
