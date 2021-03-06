// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using VirtualEvent.Model.Data;
using VirtualEvent.Model.Models;


namespace VirtualEvent.Model.Data.Configurations
{
    public partial class EventAttachmentsConfiguration : IEntityTypeConfiguration<EventAttachments>
    {
        public void Configure(EntityTypeBuilder<EventAttachments> entity)
        {
            entity.HasKey(e => e.EventAttachmentId)
                .HasName("PK_Attachments");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Event)
                .WithMany(p => p.EventAttachments)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attachments_Events");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EventAttachments> entity);
    }
}
