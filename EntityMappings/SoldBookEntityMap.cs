using ExaminationApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationApp.EntityMappings
{
    public class SoldBookEntityMap : IEntityTypeConfiguration<SoldBook>
    {
        public void Configure(EntityTypeBuilder<SoldBook> builder)
        {
            builder.HasOne(x => x.Book)
                .WithMany(x => x.SoldBooks)
                .HasForeignKey(x => x.BookId);
        }
    }
}
