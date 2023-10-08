using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class PressConfig : IEntityTypeConfiguration<Press>
    {
        public void Configure(EntityTypeBuilder<Press> builder)
        {
             // Press Id
             builder.HasKey(press => press.Id);

            // Press Name
            builder.Property(press => press.Name)
               .IsRequired()
               .HasMaxLength(30);
        }
    }
}
