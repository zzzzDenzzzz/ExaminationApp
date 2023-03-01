using ExaminationApp.Constants;
using ExaminationApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationApp.EntityMappings
{
    public class BookEntityMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(DatabaseDefaults.StringLength);
            builder.Property(x => x.Author).HasMaxLength(DatabaseDefaults.StringLength);
            builder.Property(x => x.Publisher).HasMaxLength(DatabaseDefaults.StringLength);
        }
    }
}
