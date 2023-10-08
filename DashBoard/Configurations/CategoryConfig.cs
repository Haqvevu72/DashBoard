using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Category Id
            builder.HasKey(category => category.Id);

            // Category Name
            builder.Property(category => category.Name)
                   .IsRequired()
                   .HasMaxLength(30);
        }
    }
}
