using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DashBoard.Entities;

namespace DashBoard.Configurations
{
    public class LibConfig : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {
            // Lib Id
            builder.HasKey(lib => lib.Id);

            // Lib FirstName
            builder.Property(lib => lib.FirstName)
                   .IsRequired()
                   .HasMaxLength(15);

            // Lib LastName
            builder.Property(lib => lib.LastName)
                   .IsRequired()
                   .HasMaxLength(22);

        }
    }
}
