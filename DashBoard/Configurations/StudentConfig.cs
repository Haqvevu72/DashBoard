using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Student Id
            builder.HasKey(student => student.Id);

            // FirstName
            builder.Property(student => student.FirstName)
                   .IsRequired()
                   .HasMaxLength(15);

            // LastName
            builder.Property(student => student.LastName)
                   .IsRequired()
                   .HasMaxLength(25);
        } 
    }
}
