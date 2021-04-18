﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using VirtualEvent.Model.Data;
using VirtualEvent.Model.Models;


namespace VirtualEvent.Model.Data.Configurations
{
    public partial class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> entity)
        {
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
                .WithMany(p => p.Attendance)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Attendance> entity);
    }
}
