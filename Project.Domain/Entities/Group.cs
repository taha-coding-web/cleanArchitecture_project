namespace Project.Domain.Entities;

public class Group
{
    public int Id {get ; set;}
    public string Name {get ; set;} = null!;

    public ICollection<Person> Persons {get ; set;} = new List<Person>();
}
