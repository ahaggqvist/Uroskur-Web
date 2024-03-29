﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Uroskur.DataAccess;

#nullable disable

namespace Uroskur.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Uroskur.Model.GoogleUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StravaUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StravaUserId")
                        .IsUnique();

                    b.ToTable("google_users");
                });

            modelBuilder.Entity("Uroskur.Model.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AppId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("settings");
                });

            modelBuilder.Entity("Uroskur.Model.StravaUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccessToken")
                        .HasColumnType("TEXT");

                    b.Property<long?>("AthleteId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ExpiresAt")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasAlternateKey("AthleteId");

                    b.ToTable("strava_users");
                });

            modelBuilder.Entity("Uroskur.Model.GoogleUser", b =>
                {
                    b.HasOne("Uroskur.Model.StravaUser", "StravaUser")
                        .WithOne("GoogleUser")
                        .HasForeignKey("Uroskur.Model.GoogleUser", "StravaUserId");

                    b.Navigation("StravaUser");
                });

            modelBuilder.Entity("Uroskur.Model.StravaUser", b =>
                {
                    b.Navigation("GoogleUser");
                });
#pragma warning restore 612, 618
        }
    }
}
