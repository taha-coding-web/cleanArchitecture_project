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
        .HasForeignKey(x => x.PersonId)
        .IsRequired();


        builder.HasOne(p => p.Book)
        .WithMany()
        .HasForeignKey(x => x.BookId)
        .IsRequired();

        builder.Property(x => x.LoanDate)
        .IsRequired();

        builder.Property(x => x.ReturnDate);
        


        builder.Property(x => x.Description)
        .HasMaxLength(500)
        .IsRequired();
        
    }
}