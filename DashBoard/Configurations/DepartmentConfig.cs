using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // Department Id
            builder.HasKey(department => department.Id);

            // Department Name 
            builder.Property(department => department.Name)
                   .IsRequired()
                   .HasMaxLength(40);
        }
    }
}
