namespace Project.Domain.Entities;
public class Person
{
    public int Id {get ; set;}
    public string FullName {get ; set;} = null!;
    public int GroupId {get ; set;}
    public Group Group {get ; set;} = null!;

    public ICollection <Phone> Phones {get ; set;} = new List<Phone>();
    public virtual ICollection <BookLoan> bookLoans {get ; set;} = new List<BookLoan>();

}