﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrbanEngine.Core.Application.Entities.ScheduleAggregate;

namespace UrbanEngine.Infrastructure.Persistence.Data.Configurations
{
    internal class EventConfiguration : EntityBaseConfiguration<Event, long>
    {
        public override string TableName => "Event";

        public override void Configure(EntityTypeBuilder<Event> builder)
        {
            base.Configure(builder); 

            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.Property(e => e.EndDate).IsRequired(false);
            builder.Property(e => e.StartDate).IsRequired(false);
            builder.Property(e => e.OrganizerId).IsRequired(false);
            builder.Property(e => e.VenueId).IsRequired(false);

            builder.Property(p => p.EventType)
                .HasConversion(
                    p => p.Value,
                    p => EventType.FromValue(p))
                .IsRequired();
            
            builder.HasOne(e => e.Venue)
                .WithMany(e => e.Events)
                .HasForeignKey(e => e.VenueId);
        }
    }
}