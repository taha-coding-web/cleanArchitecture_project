using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

public class PhoneConfig : IEntityTypeConfiguration<Phone>
{
    public void Configure(EntityTypeBuilder <Phone> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
        .IsRequired()
        .HasMaxLength(100);


        builder.Property(x => x.Number)
        .IsRequired()
        .HasMaxLength(11);

        builder.HasOne(p => p.Person)
        .WithMany(g => g.Phones)
        .HasForeignKey(p => p.PersonId)
        .IsRequired();
    }
}