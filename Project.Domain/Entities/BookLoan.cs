using Project.Domain.Common;

namespace Project.Domain.Entities;

public class BookLoan : BaseEntity<int>
{
    
    public Guid PersonId {get ; set;}
    public long BookId {get ; set;}

    public Person Person {get ; set;} = null!;
    public Book Book {get ; set;} = null!;
    public DateTime LoanDate {get ; set;}
    public DateTime? ReturnDate {get ; set;}
    public string? Description {get ; set;}


}