namespace Project.Domain.Entities;

public class Group
{
    public int ID {get ; set;}
    public string Name {get ; set;}

    public ICollection<Persone> Persons {get ; set;} = new List<Persone>();
}
