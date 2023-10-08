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
        }
    }
}
