using Project.Domain.Common;

namespace Project.Domain.Entities;
public class Book : BaseEntity<long>
{
    
    public string Title {get ; set;} = null!;
    public string Author {get ; set;} = null!;

 
   public virtual ICollection<BookLoan> BookLoans {get ; set;} = new List<BookLoan>();

}