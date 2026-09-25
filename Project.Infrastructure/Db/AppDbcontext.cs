using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
namespace Project.Infrastructure.Persistence;

public class AppDbcontext : DbContext
{
    public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options){}

    public DbSet<Person> People {get ; set;}
    public DbSet<BookLoan> BookLoans {get ; set;}
    public DbSet<Book> Books {get ; set;}
    public DbSet<Group> Groups {get ; set;}
    public DbSet<Phone> Phones {get ; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<BookLoan>(entity =>
        {
      



            entity.HasOne(d => d.Book)
            .WithMany(p => p.BookLoans)
            .HasForeignKey(d => d.BookId)
            .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbcontext).Assembly);
            



        }
        );
    }
} 