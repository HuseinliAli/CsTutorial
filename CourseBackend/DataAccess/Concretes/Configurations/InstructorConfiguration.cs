using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concretes.Configurations;

internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.ToTable("Instructors");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
        builder.Property(x => x.LastName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(800).IsRequired();
        builder.Property(x => x.ImagePath).HasColumnType("varchar").HasMaxLength(200).IsRequired();
    }
}

