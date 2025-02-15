﻿// <auto-generated />
using System;
using BookingManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingManagement.Migrations
{
    [DbContext(typeof(BookingDBContext))]
    partial class BookingDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommonService.Models.AirlineDetails", b =>
                {
                    b.Property<int>("AirlineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirlineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<string>("DiscountCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("AirlineId");

                    b.ToTable("AirlineDetails");
                });

            modelBuilder.Entity("CommonService.Models.BookingDetails", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoofSeats")
                        .HasColumnType("int");

                    b.Property<int?>("PNR")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("FlightId");

                    b.HasIndex("UserId");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("CommonService.Models.FlightDetails", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirlineId")
                        .HasColumnType("int");

                    b.Property<int?>("AirlinesAirlineId")
                        .HasColumnType("int");

                    b.Property<int>("BusinessClassSeats")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentUsed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NonBusinessClassSeats")
                        .HasColumnType("int");

                    b.Property<string>("PlaceFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rows")
                        .HasColumnType("int");

                    b.Property<string>("ScheduleDays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("TicketPrice")
                        .HasColumnType("float");

                    b.HasKey("FlightId");

                    b.HasIndex("AirlinesAirlineId");

                    b.ToTable("FlightDetails");
                });

            modelBuilder.Entity("CommonService.Models.PassengerDetails", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassengerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatClass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassengerId");

                    b.HasIndex("BookingId");

                    b.ToTable("PassengerDetails");
                });

            modelBuilder.Entity("CommonService.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CommonService.Models.BookingDetails", b =>
                {
                    b.HasOne("CommonService.Models.FlightDetails", "Flight")
                        .WithMany("Bookings")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommonService.Models.User", "User")
                        .WithMany("bookings")
                        .HasForeignKey("UserId");

                    b.Navigation("Flight");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CommonService.Models.FlightDetails", b =>
                {
                    b.HasOne("CommonService.Models.AirlineDetails", "Airlines")
                        .WithMany("Flights")
                        .HasForeignKey("AirlinesAirlineId");

                    b.Navigation("Airlines");
                });

            modelBuilder.Entity("CommonService.Models.PassengerDetails", b =>
                {
                    b.HasOne("CommonService.Models.BookingDetails", "BookingDetails")
                        .WithMany("PassengerDetails")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("CommonService.Models.AirlineDetails", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("CommonService.Models.BookingDetails", b =>
                {
                    b.Navigation("PassengerDetails");
                });

            modelBuilder.Entity("CommonService.Models.FlightDetails", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("CommonService.Models.User", b =>
                {
                    b.Navigation("bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
