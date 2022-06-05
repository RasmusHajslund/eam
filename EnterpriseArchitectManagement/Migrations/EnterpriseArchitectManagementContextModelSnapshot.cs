﻿// <auto-generated />
using System;
using EnterpriseArchitectManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnterpriseArchitectManagement.Migrations
{
    [DbContext(typeof(EnterpriseArchitectManagementContext))]
    partial class EnterpriseArchitectManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ComponentComponent", b =>
                {
                    b.Property<int>("InfrastructureComponentsID")
                        .HasColumnType("int");

                    b.Property<int>("IntegrationComponentsID")
                        .HasColumnType("int");

                    b.HasKey("InfrastructureComponentsID", "IntegrationComponentsID");

                    b.HasIndex("IntegrationComponentsID");

                    b.ToTable("ComponentComponent");
                });

            modelBuilder.Entity("EnterpriseArchitectManagement.Models.Application", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("AuditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndOfLifeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GoLiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("EnterpriseArchitectManagement.Models.Component", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("ApplicationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("AuditDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CodeComplexity")
                        .HasColumnType("int");

                    b.Property<string>("CodeLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndOfLifeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GoLiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Infrastructure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LinesOfCode")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatternsUsed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Security")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecuritySuggestions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SonarQube")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StandardComponent")
                        .HasColumnType("bit");

                    b.Property<string>("ThirdPartyPackages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpgradeSuggestions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationID");

                    b.ToTable("Component");
                });

            modelBuilder.Entity("ComponentComponent", b =>
                {
                    b.HasOne("EnterpriseArchitectManagement.Models.Component", null)
                        .WithMany()
                        .HasForeignKey("InfrastructureComponentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnterpriseArchitectManagement.Models.Component", null)
                        .WithMany()
                        .HasForeignKey("IntegrationComponentsID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnterpriseArchitectManagement.Models.Component", b =>
                {
                    b.HasOne("EnterpriseArchitectManagement.Models.Application", null)
                        .WithMany("Components")
                        .HasForeignKey("ApplicationID");
                });

            modelBuilder.Entity("EnterpriseArchitectManagement.Models.Application", b =>
                {
                    b.Navigation("Components");
                });
#pragma warning restore 612, 618
        }
    }
}
