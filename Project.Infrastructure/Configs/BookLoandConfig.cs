using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

public class BookLoandConfig : IEntityTypeConfiguration<BookLoan>
{
    public void Configure(EntityTypeBuilder <BookLoan> builder)
    {
        builder.HasKey(x => x.Id);



        builder.HasOne(p => p.Person)
        .WithMany(g => g.bookLoans)
        .HasForeignKey(x => x.Book)
        .IsRequired();

        builder.Property(x => x.LoanDate)
        .IsRequired();

        builder.Property(x => x.ReturnDate)
        .IsRequired();


        builder.Property(x => x.Description)
        .HasMaxLength(500)
        .IsRequired();
        
    }
}