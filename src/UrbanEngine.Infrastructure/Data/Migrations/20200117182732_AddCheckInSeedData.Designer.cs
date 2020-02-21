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
    [Migration("20200117182732_AddCheckInSeedData")]
    partial class AddCheckInSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("ue")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("UrbanEngine.Core.Entities.CheckInEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CheckedInAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

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
                            CheckedInAt = new DateTimeOffset(new DateTime(2020, 1, 17, 12, 27, 32, 91, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, -6, 0, 0, 0)),
                            DateCreated = new DateTime(2020, 1, 17, 12, 27, 32, 91, DateTimeKind.Local).AddTicks(1665),
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

                    b.Property<DateTime?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

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

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("VenueId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("VenueId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2020, 1, 17, 12, 27, 32, 90, DateTimeKind.Local).AddTicks(1720),
                            EndDate = new DateTimeOffset(new DateTime(2020, 1, 17, 12, 27, 32, 89, DateTimeKind.Unspecified).AddTicks(7316), new TimeSpan(0, -6, 0, 0, 0)),
                            EventType = 1,
                            IsDeleted = false,
                            Name = "show256",
                            StartDate = new DateTimeOffset(new DateTime(2020, 1, 17, 12, 27, 32, 89, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, -6, 0, 0, 0)),
                            VenueId = 1L
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

                    b.Property<DateTime?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

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
                            DateCreated = new DateTime(2020, 1, 17, 12, 27, 32, 73, DateTimeKind.Local).AddTicks(1324),
                            IsAvailable = false,
                            IsDeleted = false,
                            Name = "Huntsville West",
                            PostalCode = "35805",
                            Region = 1,
                            State = "AL"
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
                    b.HasOne("UrbanEngine.Core.Entities.EventVenueEntity", "Venue")
                        .WithMany("Events")
                        .HasForeignKey("VenueId");
                });
#pragma warning restore 612, 618
        }
    }
}
