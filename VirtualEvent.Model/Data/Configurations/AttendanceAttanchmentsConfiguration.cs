﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using VirtualEvent.Model.Data;
using VirtualEvent.Model.Models;


namespace VirtualEvent.Model.Data.Configurations
{
    public partial class AttendanceAttanchmentsConfiguration : IEntityTypeConfiguration<AttendanceAttanchments>
    {
        public void Configure(EntityTypeBuilder<AttendanceAttanchments> entity)
        {
            entity.HasKey(e => e.AttendanceAttachmentId);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Attendance)
                .WithMany(p => p.AttendanceAttanchments)
                .HasForeignKey(d => d.AttendanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttendanceAttanchments_Attendance");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AttendanceAttanchments> entity);
    }
}