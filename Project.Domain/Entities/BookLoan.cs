namespace Project.Domain.Entities;

public class BookLoan
{
    public int Id {get ; set;}
    public int PersonId {get ; set;}
    public int BookId {get ; set;}

    public Person Person {get ; set;} = null!;
    public Book Book {get ; set;} = null!;
    public DateTime LoanDate {get ; set;}
    public DateTime? ReturnDate {get ; set;}
    public string? Description {get ; set;}


}