using DashBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashBoard.Configurations
{
    public class S_CradConfig : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {
            // Id
            builder.HasKey(s_card => s_card.Id);

            // Relationship S_Card Between (Book,Student) (Many-to-Many)
            builder.HasOne<Book>()
                   .WithMany()
                   .HasForeignKey(s_card => s_card.Id_Book);

            builder.HasOne<Student>()
                   .WithMany()
                   .HasForeignKey(s_card => s_card.Id_Student);

            // Relationship between T_Card and Lib (One-to-Many)
            builder.HasOne<Lib>()
                   .WithMany()
                   .HasForeignKey(s_card => s_card.Id_Lib);
        }
    }
}
