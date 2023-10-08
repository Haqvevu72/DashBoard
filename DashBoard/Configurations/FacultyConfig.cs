using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class FacultyConfig : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            // Department Id
            builder.HasKey(faculty => faculty.Id);

            // Department Name 
            builder.Property(faculty => faculty.Name)
                   .IsRequired()
                   .HasMaxLength(20);
        }
    }
}
