namespace Project.Domain.Entities;
public class Persone
{
    public int ID {get ; set;}
    public string FullName {get ; set;}
    public int GroupID {get ; set;}
    public Group Group {get ; set;}

    public ICollection<Phone> PhoneNumber {get ; set;} = new List<Phone>();
    public ICollection <Book> Borrowings {get ; set;} = new List<Book>();

}