using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksApp.Domain.Entities;

namespace TasksApp.Infraestructure.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(x => x.CreatedDate)
                .HasColumnType("datetime2")
                .HasDefaultValue(null);

            builder.Property(e => e.UpdatedDate)
                .HasColumnType("datetime2")
                .HasDefaultValue(null);
        }
    }
}
