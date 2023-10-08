using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            // Student Id
            builder.HasKey(teacher => teacher.Id);

            // FirstName
            builder.Property(teacher => teacher.FirstName)
                   .IsRequired()
                   .HasMaxLength(15);

            // LastName
            builder.Property(teacher => teacher.LastName)
                   .IsRequired()
                   .HasMaxLength(25);
        }
    }
}
