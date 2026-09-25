namespace Project.Domain.Common;

public abstract class BaseEntity<Tkey>
{
    public Tkey Id {get ; set;}
    public DateTime Created {get ; set;} = DateTime.Now;
    public DateTime? LastUpdateDate {get ; set;}
}
