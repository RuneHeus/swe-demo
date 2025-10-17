using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SweDemoBackend.Domain.Entities;

namespace SweDemoBackend.Infrastructure.Configurations
{
  public class LegoSetConfiguration : IEntityTypeConfiguration<LegoSet>
  {
    public void Configure(EntityTypeBuilder<LegoSet> b)
    {
      b.ToTable("LegoSet");
    }
  }
}
