using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeeMessenger.Data.Entities;

namespace VeeMessenger.Data.EntityConfigurations
{
    public class RefreshSessionConfiguration : IEntityTypeConfiguration<RefreshSession>
    {
        public void Configure(EntityTypeBuilder<RefreshSession> builder)
        {
            builder.ToTable("RefreshSessions");
            builder.HasKey(refreshSession => refreshSession.Id);

            builder
                .HasOne(refreshSession => refreshSession.User)
                .WithMany(user => user.RefreshSessions);
        }
    }
}
