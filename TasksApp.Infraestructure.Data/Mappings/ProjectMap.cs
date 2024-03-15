using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Domain.Entities;

namespace TasksApp.Infraestructure.Data.Mappings
{
    public class ProjectMap : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(x => x.CreatedDate)
                .HasColumnType("datetime2")
                .HasDefaultValue(null);

            builder.Property(e => e.UpdatedDate)
                .HasColumnType("datetime2")
                .HasDefaultValue(null);

            builder.HasOne(x => x.User)
            .WithMany(x => x.Projects)
            .HasForeignKey(x => x.UserId);
        }
    }
}
