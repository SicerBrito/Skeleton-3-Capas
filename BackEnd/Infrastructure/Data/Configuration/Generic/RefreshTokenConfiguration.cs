using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>{

        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.ToTable("RefreshToken");

            builder.Property(p => p.Id)
            .IsRequired();
        }

    }
