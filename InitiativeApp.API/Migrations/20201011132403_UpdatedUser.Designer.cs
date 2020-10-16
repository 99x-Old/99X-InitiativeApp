﻿// <auto-generated />
using System;
using InitiativeApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InitiativeApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201011132403_UpdatedUser")]
    partial class UpdatedUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InitiativeApp.API.Models.Initiative", b =>
                {
                    b.Property<int>("InitiativeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InCharge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InitiativeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InitiativeId");

                    b.ToTable("Initiatives");
                });

            modelBuilder.Entity("InitiativeApp.API.Models.Meeting", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InitiativeId")
                        .HasColumnType("int");

                    b.Property<string>("MeetingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ScheduledTime")
                        .HasColumnType("datetime2");

                    b.HasKey("MeetingId");

                    b.HasIndex("InitiativeId");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("InitiativeApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InitiativeApp.API.Models.Meeting", b =>
                {
                    b.HasOne("InitiativeApp.API.Models.Initiative", null)
                        .WithMany("Meetings")
                        .HasForeignKey("InitiativeId");
                });
#pragma warning restore 612, 618
        }
    }
}
