using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.Configurations;

internal class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(500).IsRequired();
        builder.Property(x => x.ImagePath).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        builder.Property(x => x.CategoryId).HasColumnType("int").IsRequired();
        builder.Property(x => x.InstructorId).HasColumnType("uniqueidentifier").IsRequired();

        builder.HasOne<Category>().WithMany().HasForeignKey(x => x.CategoryId);
        builder.HasOne<Instructor>().WithMany().HasForeignKey(x => x.InstructorId);
    }
}

