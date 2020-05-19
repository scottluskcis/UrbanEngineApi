﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UrbanEngine.Infrastructure.Data;

namespace UrbanEngine.Infrastructure.Data.Migrations
{
    [DbContext(typeof(UrbanEngineDbContext))]
    [Migration("20200228190435_SwitchToDateTimeOffset")]
    partial class SwitchToDateTimeOffset
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("ue")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("UrbanEngine.Core.Entities.CheckInEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CheckedInAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("EventId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("CheckIn");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CheckedInAt = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 410, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -5, 0, 0, 0)),
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 410, DateTimeKind.Unspecified).AddTicks(6036), new TimeSpan(0, -5, 0, 0, 0)),
                            EventId = 1L,
                            IsDeleted = false,
                            UserId = 0L
                        });
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.EventEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

                    b.Property<long?>("EventVenueEntityId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("OrganizerId")
                        .HasColumnType("text");

                    b.Property<long?>("RoomId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EventVenueEntityId");

                    b.HasIndex("RoomId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 409, DateTimeKind.Unspecified).AddTicks(7633), new TimeSpan(0, -5, 0, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 409, DateTimeKind.Unspecified).AddTicks(5302), new TimeSpan(0, -5, 0, 0, 0)),
                            EventType = 1,
                            IsDeleted = false,
                            Name = "show256",
                            RoomId = 4L,
                            StartDate = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 409, DateTimeKind.Unspecified).AddTicks(5216), new TimeSpan(0, -5, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 410, DateTimeKind.Unspecified).AddTicks(3083), new TimeSpan(0, -5, 0, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 410, DateTimeKind.Unspecified).AddTicks(3045), new TimeSpan(0, -5, 0, 0, 0)),
                            EventType = 1,
                            IsDeleted = false,
                            Name = "Designer's Corner",
                            RoomId = 2L,
                            StartDate = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 410, DateTimeKind.Unspecified).AddTicks(3004), new TimeSpan(0, -5, 0, 0, 0))
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 410, DateTimeKind.Unspecified).AddTicks(3165), new TimeSpan(0, -5, 0, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 410, DateTimeKind.Unspecified).AddTicks(3160), new TimeSpan(0, -5, 0, 0, 0)),
                            EventType = 1,
                            IsDeleted = false,
                            Name = "Huntsville AI",
                            RoomId = 5L,
                            StartDate = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 410, DateTimeKind.Unspecified).AddTicks(3155), new TimeSpan(0, -5, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.EventVenueEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Address2")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("Country")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<DateTimeOffset?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("PostalCode")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("Region")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Venue");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "3001 9th Avenue Southwest",
                            City = "Huntsville",
                            Country = "United States",
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 399, DateTimeKind.Unspecified).AddTicks(9789), new TimeSpan(0, -5, 0, 0, 0)),
                            IsAvailable = false,
                            IsDeleted = false,
                            Name = "Huntsville West",
                            PostalCode = "35805",
                            Region = 1,
                            State = "AL"
                        });
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.RoomEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Capacity")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<bool?>("HasTVOrProjector")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Resources")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<long?>("VenueId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("VenueId");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 411, DateTimeKind.Unspecified).AddTicks(4005), new TimeSpan(0, -5, 0, 0, 0)),
                            Description = "Cafe Conference Room",
                            HasTVOrProjector = true,
                            IsDeleted = false,
                            Name = "Cafe Conference Room",
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 411, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, -5, 0, 0, 0)),
                            Description = "Front Conference Room",
                            HasTVOrProjector = true,
                            IsDeleted = false,
                            Name = "Front Conference Room",
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 411, DateTimeKind.Unspecified).AddTicks(9312), new TimeSpan(0, -5, 0, 0, 0)),
                            Description = "Corner Conference Room",
                            HasTVOrProjector = true,
                            IsDeleted = false,
                            Name = "Corner Conference Room",
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 411, DateTimeKind.Unspecified).AddTicks(9319), new TimeSpan(0, -5, 0, 0, 0)),
                            Description = "Library",
                            HasTVOrProjector = false,
                            IsDeleted = false,
                            Name = "Library",
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            DateCreated = new DateTimeOffset(new DateTime(2020, 2, 28, 14, 4, 34, 411, DateTimeKind.Unspecified).AddTicks(9325), new TimeSpan(0, -5, 0, 0, 0)),
                            Description = "Training Room",
                            HasTVOrProjector = true,
                            IsDeleted = false,
                            Name = "Training Room",
                            VenueId = 1L
                        });
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.CheckInEntity", b =>
                {
                    b.HasOne("UrbanEngine.Core.Entities.EventEntity", "Event")
                        .WithMany("CheckIns")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.EventEntity", b =>
                {
                    b.HasOne("UrbanEngine.Core.Entities.EventVenueEntity", null)
                        .WithMany("Events")
                        .HasForeignKey("EventVenueEntityId");

                    b.HasOne("UrbanEngine.Core.Entities.RoomEntity", "Room")
                        .WithMany("Events")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.RoomEntity", b =>
                {
                    b.HasOne("UrbanEngine.Core.Entities.EventVenueEntity", "Venue")
                        .WithMany("Rooms")
                        .HasForeignKey("VenueId");
                });
#pragma warning restore 612, 618
        }
    }
}