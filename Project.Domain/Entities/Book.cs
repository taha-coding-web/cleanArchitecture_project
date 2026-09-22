namespace Project.Domain.Entities;
public class Book
{
    public int ID {get ; set;}
    public string Title {get ; set;}
    public string Author {get ; set;}

   public ICollection<Persone> Borrowedby {get ; set;} = new List<Persone>();

}