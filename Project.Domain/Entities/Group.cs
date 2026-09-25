using Project.Domain.Common;

namespace Project.Domain.Entities;

public class Group : BaseEntity<int>
{
    
    public string Name {get ; set;} = null!;

    public ICollection<Person> People {get ; set;} = new List<Person>();
}
