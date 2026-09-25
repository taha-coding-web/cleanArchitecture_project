using Project.Domain.Common;

namespace Project.Domain.Entities;

public class Phone : BaseEntity<int>
{
   
    public string Title {get ; set;} = null!;
    public string Number {get ; set;} = null!;

    public int PersonId {get ; set;}
    public Person Person {get ; set;} = null!;
}