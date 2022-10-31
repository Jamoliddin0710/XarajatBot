using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context;
public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.ToTable("rooms").Property(room => room.Name).
            IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(room=>room.Key).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(room => room.RoomStatus).HasDefaultValue(RoomStatus.Created).
            IsRequired();
    }
}

