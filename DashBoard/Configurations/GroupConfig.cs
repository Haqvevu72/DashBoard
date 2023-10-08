using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DashBoard.Entities;

namespace DashBoard.Configurations
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            // Group Id
            builder.HasKey(group => group.Id);

            // Group Name 
            builder.Property(group => group.Name)
                   .IsRequired()
                   .HasMaxLength(10);
        }
    }
}
