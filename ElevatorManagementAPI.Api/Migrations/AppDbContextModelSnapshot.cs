﻿// <auto-generated />
using System;
using ElevatorManagementAPI.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElevatorManagementAPI.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.AddressModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BuildingId")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId")
                        .IsUnique();

                    b.ToTable("Addresses", (string)null);
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.AssigneeModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BuildingId")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("assignees", (string)null);
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.BuildingModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AssigneeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("TenantId");

                    b.HasIndex("UserId");

                    b.ToTable("Buildings", (string)null);
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.ElevatorModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BuildingId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Buttom")
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("CableGauge")
                        .HasColumnType("int");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Command")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("DoorOperator")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FrequencyInversor")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ipd")
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsHouseMachineLess")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsHouseMachineOnTop")
                        .HasColumnType("boolean");

                    b.Property<string>("Machine")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("MaintenedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("OilType")
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("People")
                        .HasColumnType("int");

                    b.Property<int?>("QttCables")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("StopsNum")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Technology")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("VelocityNum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("TenantId");

                    b.HasIndex("UserId");

                    b.ToTable("Elevators", (string)null);
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.PendencyModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ClosedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("ElevatorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Picture")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ElevatorId");

                    b.HasIndex("TenantId");

                    b.HasIndex("UserId");

                    b.ToTable("Pendencies", (string)null);
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.SubscriptionModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid>("PlanID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("StripeSubscriptionId")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Subscriptions", (string)null);
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.TenantModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsSubActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TenantColor")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TenantLogo")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Tenants", (string)null);
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.UserModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("PasswordChangedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TenantModelId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.HasIndex("TenantModelId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.VisitModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BuildingId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ClosedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int?>("CurrentFloor")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ElevatorStatusPos")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ElevatorStatusPre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsPassengerStucked")
                        .HasColumnType("boolean");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("TenantId");

                    b.HasIndex("UserId");

                    b.ToTable("Visits", (string)null);
                });

            modelBuilder.Entity("VisitsElevators", b =>
                {
                    b.Property<Guid>("ElevatorId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VisitId")
                        .HasColumnType("TEXT");

                    b.HasKey("ElevatorId", "VisitId");

                    b.HasIndex("VisitId");

                    b.ToTable("VisitsElevators");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.AddressModel", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.BuildingModel", "Building")
                        .WithOne("Address")
                        .HasForeignKey("ElevatorManagementAPI.Domain.Models.AddressModel", "BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.AssigneeModel", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.TenantModel", "Tenant")
                        .WithMany("Assignees")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.BuildingModel", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.AssigneeModel", "Assignee")
                        .WithMany("Buildings")
                        .HasForeignKey("AssigneeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElevatorManagementAPI.Domain.Models.TenantModel", "Tenant")
                        .WithMany("Buildings")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElevatorManagementAPI.Domain.Models.UserModel", "User")
                        .WithMany("Buildings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignee");

                    b.Navigation("Tenant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.ElevatorModel", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.BuildingModel", "Building")
                        .WithMany("Elevators")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElevatorManagementAPI.Domain.Models.TenantModel", "Tenant")
                        .WithMany("Elevators")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElevatorManagementAPI.Domain.Models.UserModel", "User")
                        .WithMany("Elevators")
                        .HasForeignKey("UserId");

                    b.Navigation("Building");

                    b.Navigation("Tenant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.PendencyModel", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.ElevatorModel", "Elevator")
                        .WithMany("Pendencies")
                        .HasForeignKey("ElevatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElevatorManagementAPI.Domain.Models.TenantModel", "Tenant")
                        .WithMany("Pendencies")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElevatorManagementAPI.Domain.Models.UserModel", "User")
                        .WithMany("Pendencies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Elevator");

                    b.Navigation("Tenant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.SubscriptionModel", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.TenantModel", "Tenant")
                        .WithMany("Subscriptions")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.TenantModel", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.AddressModel", "Address")
                        .WithOne("Tenant")
                        .HasForeignKey("ElevatorManagementAPI.Domain.Models.TenantModel", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Address");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.UserModel", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.TenantModel", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElevatorManagementAPI.Domain.Models.TenantModel", null)
                        .WithMany("Users")
                        .HasForeignKey("TenantModelId");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.VisitModel", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.BuildingModel", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElevatorManagementAPI.Domain.Models.TenantModel", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElevatorManagementAPI.Domain.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");

                    b.Navigation("Tenant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VisitsElevators", b =>
                {
                    b.HasOne("ElevatorManagementAPI.Domain.Models.ElevatorModel", null)
                        .WithMany()
                        .HasForeignKey("ElevatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VisitElevators_Elevators_ElevatorModelId");

                    b.HasOne("ElevatorManagementAPI.Domain.Models.VisitModel", null)
                        .WithMany()
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VisitElevators_Visits_VisitModelId");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.AddressModel", b =>
                {
                    b.Navigation("Tenant")
                        .IsRequired();
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.AssigneeModel", b =>
                {
                    b.Navigation("Buildings");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.BuildingModel", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Elevators");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.ElevatorModel", b =>
                {
                    b.Navigation("Pendencies");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.TenantModel", b =>
                {
                    b.Navigation("Assignees");

                    b.Navigation("Buildings");

                    b.Navigation("Elevators");

                    b.Navigation("Pendencies");

                    b.Navigation("Subscriptions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ElevatorManagementAPI.Domain.Models.UserModel", b =>
                {
                    b.Navigation("Buildings");

                    b.Navigation("Elevators");

                    b.Navigation("Pendencies");
                });
#pragma warning restore 612, 618
        }
    }
}
