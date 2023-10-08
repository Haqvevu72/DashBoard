using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            // Book Id
            builder.HasKey(book => book.Id);

            // Book Name
            builder.Property(book => book.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // Book Pages
            builder.Property(book => book.Pages)
                   .IsRequired()
                   .HasColumnType("smallint");

            // Book YearPress
            builder.Property(book => book.YearPress)
                   .IsRequired();

            // Book Comment
            builder.Property(book => book.Comment)
                   .IsRequired()
                   .HasColumnType("nvarchar(max)");

            // Book Quantity
            builder.Property(book => book.Quantity)
                   .IsRequired()
                   .HasColumnType("bigint");

        }
    }
}
