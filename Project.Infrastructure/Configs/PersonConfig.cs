using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

public class PersonConfig : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder <Person> builder)
    {
        builder.HasKey(x => x.Id);


        builder.Property(x => x.FullName)
        .IsRequired()
        .HasMaxLength(45);


        builder.HasOne(p => p.Group)
        .WithMany(g => g.People)
        .HasForeignKey(p => p.GroupId)
        .IsRequired();
    }
}