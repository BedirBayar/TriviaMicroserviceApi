﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TriviaContestApi.DataAccess;

#nullable disable

namespace TriviaContestApi.Migrations
{
    [DbContext(typeof(ContestDbContext))]
    [Migration("20241011220413_Matchesfixed")]
    partial class Matchesfixed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.Category", b =>
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

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Name");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.Contest", b =>
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

                    b.Property<int>("AwardId")
                        .HasColumnType("int")
                        .HasColumnName("AwardId");

                    b.Property<int>("ContestTypeId")
                        .HasColumnType("int")
                        .HasColumnName("ContestTypeId");

                    b.Property<int>("ContestantNumber")
                        .HasColumnType("int")
                        .HasColumnName("ContestantNumber");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EndDate");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<bool>("IsPeriodic")
                        .HasColumnType("bit")
                        .HasColumnName("IsPeriodic");

                    b.Property<bool>("IsRunning")
                        .HasColumnType("bit")
                        .HasColumnName("IsRunning");

                    b.Property<int>("LeaderBoardId")
                        .HasColumnType("int")
                        .HasColumnName("LeaderBoardId");

                    b.Property<int>("MatchFrequency")
                        .HasColumnType("int")
                        .HasColumnName("MatchFrequency");

                    b.Property<int>("MaximumRank")
                        .HasColumnType("int")
                        .HasColumnName("MaximumRank");

                    b.Property<int>("MinimumRank")
                        .HasColumnType("int")
                        .HasColumnName("MinimumRank");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Name");

                    b.Property<string>("PeriodType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PeriodType");

                    b.Property<decimal>("PrizeRating")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PrizeRating");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartDate");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ContestTypeId");

                    b.HasIndex("LeaderBoardId");

                    b.ToTable("Contests");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.ContestAward", b =>
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

                    b.Property<int>("AwardId")
                        .HasColumnType("int")
                        .HasColumnName("AwardId");

                    b.Property<int>("AwardRating")
                        .HasColumnType("int")
                        .HasColumnName("AwardRating");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<int>("LeaderBoardRank")
                        .HasColumnType("int")
                        .HasColumnName("LeaderBoardRank");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Name");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("ContestAwards");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.ContestRule", b =>
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

                    b.Property<int>("ContestTypeId")
                        .HasColumnType("int")
                        .HasColumnName("ContestTypeId");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<int>("Order")
                        .HasColumnType("int")
                        .HasColumnName("Order");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ContestTypeId");

                    b.ToTable("ContestRules");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.ContestType", b =>
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

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Name");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("ContestTypes");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.LeaderBoard", b =>
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

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit")
                        .HasColumnName("IsComplete");

                    b.Property<bool>("IsTeamLeaderBoard")
                        .HasColumnType("bit")
                        .HasColumnName("IsTeamLeaderBoard");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Notes");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("LeaderBoards");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Answer");

                    b.Property<int>("ArchivedBy")
                        .HasColumnType("int")
                        .HasColumnName("ArchivedBy");

                    b.Property<DateTime?>("ArchivedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("ArchivedOn");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryId");

                    b.Property<string>("Choice1")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Choice1");

                    b.Property<string>("Choice2")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Choice2");

                    b.Property<string>("Choice3")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Choice3");

                    b.Property<string>("Choice4")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Choice4");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int")
                        .HasColumnName("Difficulty");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Image");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Text");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.TeamMatch", b =>
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

                    b.Property<int>("ContestId")
                        .HasColumnType("int")
                        .HasColumnName("ContestId");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EndDate");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<bool>("IsLeagueMatch")
                        .HasColumnType("bit")
                        .HasColumnName("IsLeagueMatch");

                    b.Property<bool>("IsTeamMatch")
                        .HasColumnType("bit")
                        .HasColumnName("IsTeamMatch");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartDate");

                    b.Property<int>("Team1Id")
                        .HasColumnType("int")
                        .HasColumnName("Team1Id");

                    b.Property<int>("Team1Score")
                        .HasColumnType("int")
                        .HasColumnName("Team1Score");

                    b.Property<int>("Team2Id")
                        .HasColumnType("int")
                        .HasColumnName("Team2Id");

                    b.Property<int>("Team2Score")
                        .HasColumnType("int")
                        .HasColumnName("Team2Score");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.ToTable("TeamMatches");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.UserMatch", b =>
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

                    b.Property<int>("ContestId")
                        .HasColumnType("int")
                        .HasColumnName("ContestId");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EndDate");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<bool>("IsLeagueMatch")
                        .HasColumnType("bit")
                        .HasColumnName("IsLeagueMatch");

                    b.Property<bool>("IsTeamMatch")
                        .HasColumnType("bit")
                        .HasColumnName("IsTeamMatch");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartDate");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.Property<int>("User1Id")
                        .HasColumnType("int")
                        .HasColumnName("User1Id");

                    b.Property<int>("User1Score")
                        .HasColumnType("int")
                        .HasColumnName("User1Score");

                    b.Property<int>("User2Id")
                        .HasColumnType("int")
                        .HasColumnName("User2Id");

                    b.Property<int>("User2Score")
                        .HasColumnType("int")
                        .HasColumnName("User2Score");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.ToTable("UserMatches");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.ContestTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContestId")
                        .HasColumnType("int")
                        .HasColumnName("ContestId");

                    b.Property<int>("TeamId")
                        .HasColumnType("int")
                        .HasColumnName("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.ToTable("ContestTeams");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.LeaderBoardTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LeaderBoardId")
                        .HasColumnType("int")
                        .HasColumnName("LeaderBoardId");

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasColumnName("Points");

                    b.Property<int>("TeamId")
                        .HasColumnType("int")
                        .HasColumnName("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("LeaderBoardId");

                    b.ToTable("LeaderBoardTeams");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.LeaderBoardUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LeaderBoardId")
                        .HasColumnType("int")
                        .HasColumnName("LeaderBoardId");

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasColumnName("Points");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("LeaderBoardId");

                    b.ToTable("LeaderBoardUsers");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.TeamMatchQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionId");

                    b.Property<int>("TeamMatchId")
                        .HasColumnType("int")
                        .HasColumnName("MatchId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TeamMatchId");

                    b.ToTable("TeamMatchQuestions");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.UserMatchQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionId");

                    b.Property<int>("UserMatchId")
                        .HasColumnType("int")
                        .HasColumnName("MatchId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserMatchId");

                    b.ToTable("UserMatchQuestions");
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.Contest", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.ContestType", null)
                        .WithMany()
                        .HasForeignKey("ContestTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TriviaContestApi.DataAccess.Entities.LeaderBoard", null)
                        .WithMany()
                        .HasForeignKey("LeaderBoardId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.ContestRule", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.ContestType", null)
                        .WithMany()
                        .HasForeignKey("ContestTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.Question", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.TeamMatch", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.Contest", null)
                        .WithMany()
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Entities.UserMatch", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.Contest", null)
                        .WithMany()
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.ContestTeam", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.Contest", null)
                        .WithMany()
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.LeaderBoardTeam", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.LeaderBoard", null)
                        .WithMany()
                        .HasForeignKey("LeaderBoardId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.LeaderBoardUser", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.LeaderBoard", null)
                        .WithMany()
                        .HasForeignKey("LeaderBoardId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.TeamMatchQuestion", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TriviaContestApi.DataAccess.Entities.TeamMatch", null)
                        .WithMany()
                        .HasForeignKey("TeamMatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContestApi.DataAccess.Relationships.UserMatchQuestion", b =>
                {
                    b.HasOne("TriviaContestApi.DataAccess.Entities.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TriviaContestApi.DataAccess.Entities.UserMatch", null)
                        .WithMany()
                        .HasForeignKey("UserMatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
