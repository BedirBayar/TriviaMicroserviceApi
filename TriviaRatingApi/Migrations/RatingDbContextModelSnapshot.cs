﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TriviaRatingApi.DataLayer;

#nullable disable

namespace TriviaRatingApi.Migrations
{
    [DbContext(typeof(RatingDbContext))]
    partial class RatingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Entities.Award", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArchivedBy")
                        .HasColumnType("int")
                        .HasColumnName("ArchivedBy");

                    b.Property<DateTime?>("ArchivedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("ArchivedOn");

                    b.Property<string>("Badge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.Property<string>("UserOrTeam")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.ToTable("Awards");
                });

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Entities.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArchivedBy")
                        .HasColumnType("int")
                        .HasColumnName("ArchivedBy");

                    b.Property<DateTime?>("ArchivedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("ArchivedOn");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.Property<string>("UserOrTeam")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArchivedBy")
                        .HasColumnType("int")
                        .HasColumnName("ArchivedBy");

                    b.Property<DateTime?>("ArchivedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("ArchivedOn");

                    b.Property<string>("BanReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BannedUntil")
                        .HasColumnType("datetime");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<bool>("IsBanned")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("LeaderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Slogan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Relationships.TeamAward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AwardId")
                        .HasColumnType("int")
                        .HasColumnName("AwardId");

                    b.Property<int>("TeamId")
                        .HasColumnType("int")
                        .HasColumnName("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId", "AwardId");

                    b.ToTable("TeamAward");
                });

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Relationships.TeamRank", b =>
                {
                    b.Property<int>("TeamId")
                        .HasColumnType("int")
                        .HasColumnName("TeamId");

                    b.Property<int>("RankDegree")
                        .HasColumnType("int")
                        .HasColumnName("RankDegree");

                    b.HasKey("TeamId", "RankDegree");

                    b.ToTable("TeamRank");
                });

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Relationships.TeamRating", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TeamId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"));

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Rating");

                    b.HasKey("TeamId");

                    b.ToTable("TeamRating");
                });

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Relationships.UserAward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AwardId")
                        .HasColumnType("int")
                        .HasColumnName("AwardId");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "AwardId");

                    b.ToTable("UserAward");
                });

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Relationships.UserRank", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("RankDegree")
                        .HasColumnType("int")
                        .HasColumnName("RankDegree");

                    b.HasKey("UserId");

                    b.ToTable("UserRank");
                });

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Relationships.UserRating", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("RankDegree");

                    b.HasKey("UserId");

                    b.ToTable("UserRating");
                });

            modelBuilder.Entity("TriviaRatingApi.DataLayer.Relationships.UserTeam", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.Property<int>("TeamId")
                        .HasColumnType("int")
                        .HasColumnName("TeamId");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.HasKey("UserId", "TeamId");

                    b.ToTable("UserTeam");
                });
#pragma warning restore 612, 618
        }
    }
}
