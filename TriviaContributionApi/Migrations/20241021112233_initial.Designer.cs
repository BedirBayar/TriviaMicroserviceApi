﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TriviaContributionApi.DataLayer;

#nullable disable

namespace TriviaContributionApi.Migrations
{
    [DbContext(typeof(ContributionDbContext))]
    [Migration("20241021112233_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TriviaContributionApi.DataLayer.Entities.QuestionDraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
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
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Choice1");

                    b.Property<string>("Choice2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Choice2");

                    b.Property<string>("Choice3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Choice3");

                    b.Property<string>("Choice4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
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
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Image");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit")
                        .HasColumnName("IsArchived");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Text");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("QuestionDraft");
                });

            modelBuilder.Entity("TriviaContributionApi.DataLayer.Relationships.QuestionDifficulty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DifficultyPoint")
                        .HasColumnType("int")
                        .HasColumnName("DifficultyPoint");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionId");

                    b.HasKey("Id");

                    b.ToTable("QuestionDifficulty");
                });

            modelBuilder.Entity("TriviaContributionApi.DataLayer.Relationships.QuestionDraftDifficulty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DifficultyPoint")
                        .HasColumnType("int")
                        .HasColumnName("DifficultyPoint");

                    b.Property<int>("QuestionDraftId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionDraftId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionDraftId");

                    b.ToTable("QuestionDraftDifficulty");
                });

            modelBuilder.Entity("TriviaContributionApi.DataLayer.Relationships.QuestionDraftQuality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Feedback");

                    b.Property<int>("QualityPoint")
                        .HasColumnType("int")
                        .HasColumnName("QualityPoint");

                    b.Property<int>("QuestionDraftId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionDraftId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionDraftId");

                    b.ToTable("QuestionDraftQuality");
                });

            modelBuilder.Entity("TriviaContributionApi.DataLayer.Relationships.QuestionQuality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Feedback");

                    b.Property<int>("QualityPoint")
                        .HasColumnType("int")
                        .HasColumnName("QualityPoint");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionId");

                    b.HasKey("Id");

                    b.ToTable("QuestionQuality");
                });

            modelBuilder.Entity("TriviaContributionApi.DataLayer.Relationships.UserContributionRating", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<decimal>("ContributionRating")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("ContributionRating");

                    b.HasKey("UserId");

                    b.ToTable("UserContributionRating");
                });

            modelBuilder.Entity("TriviaContributionApi.DataLayer.Relationships.QuestionDraftDifficulty", b =>
                {
                    b.HasOne("TriviaContributionApi.DataLayer.Entities.QuestionDraft", null)
                        .WithMany()
                        .HasForeignKey("QuestionDraftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TriviaContributionApi.DataLayer.Relationships.QuestionDraftQuality", b =>
                {
                    b.HasOne("TriviaContributionApi.DataLayer.Entities.QuestionDraft", null)
                        .WithMany()
                        .HasForeignKey("QuestionDraftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}