namespace Project.Domain.Entities;

public class Phone
{
    public int Id {get ; set;}
    public string Title {get ; set;} = null!;
    public string Number {get ; set;} = null!;

    public int PersonId {get ; set;}
    public Person Person {get ; set;} = null!;
}