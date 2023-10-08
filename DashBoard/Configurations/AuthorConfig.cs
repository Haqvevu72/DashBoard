using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            // Author Id
            builder.HasKey(author => author.Id);
            
            // FirstName 
            builder.Property(author => author.FirstName)
                   .IsRequired()
                   .HasMaxLength(15);

            // LastName
            builder.Property(author => author.LastName)
                   .IsRequired()
                   .HasMaxLength(25);
        }
    }
}
