using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder <Book> builder)
    {
        builder.HasKey(x => x.Id);
       
       builder.Property(x => x.Title)
       .IsRequired()
       .HasMaxLength(200);

       
       builder.Property(x => x.Author)
       .IsRequired()
       .HasMaxLength(100);
    }
}