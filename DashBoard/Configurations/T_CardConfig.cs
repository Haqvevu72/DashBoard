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
        }
    }
}
