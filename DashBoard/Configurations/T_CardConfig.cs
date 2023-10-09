using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class T_CardConfig : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            // Id
            builder.HasKey(t_card => t_card.Id);

            // Relationship T_Card Between (Book,Teacher) (Many-to-Many)
            builder.HasOne<Book>()
                   .WithMany()
                   .HasForeignKey(t_card => t_card.Id_Book);

            builder.HasOne<Teacher>()
                   .WithMany()
                   .HasForeignKey(t_card => t_card.Id_Teacher);

            // Relationship between T_Card and Lib (One-to-Many)
            builder.HasOne<Lib>()
                   .WithMany()
                   .HasForeignKey(t_card => t_card.Id_Lib);
        }
    }
}
