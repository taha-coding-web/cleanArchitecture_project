using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

public class GroupConfig : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder <Group> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.Name)
        .HasMaxLength(30)
        .IsRequired();

    }
}