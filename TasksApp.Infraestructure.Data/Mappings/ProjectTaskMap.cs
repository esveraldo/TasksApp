using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksApp.Domain.Entities;

namespace TasksApp.Infraestructure.Data.Mappings
{
    public class ProjectTaskMap : IEntityTypeConfiguration<ProjectTask>
    {
        public void Configure(EntityTypeBuilder<ProjectTask> builder)
        {
            builder.HasKey(pt => pt.Id);

            builder.Property(x => x.CreatedDate)
                .HasColumnType("datetime2")
                .HasDefaultValue(null);

            builder.Property(e => e.UpdatedDate)
                .HasColumnType("datetime2")
                .HasDefaultValue(null);

            builder.HasOne(x => x.Project)
            .WithMany(x => x.ProjectTasks)
            .HasForeignKey(x => x.ProjectId);
        }
    }
}
