using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class ThemeConfig : IEntityTypeConfiguration<Theme>
    {
        public void Configure(EntityTypeBuilder<Theme> builder)
        {
            // Theme Id
            builder.HasKey(theme => theme.Id);

            // Name
            builder.Property(theme => theme.Name)
                   .IsRequired()
                   .HasMaxLength(15);
        }
    }
}
