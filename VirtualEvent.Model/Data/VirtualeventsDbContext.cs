﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VirtualEvent.Model.Models;

#nullable disable

namespace VirtualEvent.Model.Data
{
    public partial class VirtualeventsDbContext : DbContext
    {
        public VirtualeventsDbContext()
        {
        }

        public VirtualeventsDbContext(DbContextOptions<VirtualeventsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttendanceAttanchments> AttendanceAttanchments { get; set; }
        public virtual DbSet<Attendances> Attendances { get; set; }
        public virtual DbSet<EventAttachments> EventAttachments { get; set; }
        public virtual DbSet<Events> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttendanceAttanchments>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR (50)");

                entity.HasOne(d => d.Attendance)
                    .WithMany(p => p.AttendanceAttanchments)
                    .HasForeignKey(d => d.AttendanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Attendances>(entity =>
            {
                entity.HasKey(e => e.AttendanceId);

                entity.Property(e => e.AttendanceDate)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("VARCHAR (50)");

                entity.Property(e => e.EventId).HasColumnType("INT");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnType("VARCHAR (250)");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EventAttachments>(entity =>
            {
                entity.HasKey(e => e.EventAttachmentId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR (50)");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventAttachments)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnType("TIME");

                entity.Property(e => e.OrganizerId)
                    .IsRequired()
                    .HasColumnType("VARCHAR (50)");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnType("TIME");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("VARCHAR (250)");

                entity.Property(e => e.Url).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}