using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeeMessenger.Data.Entities;

namespace VeeMessenger.Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(user => user.Id);

            builder.HasOne(user => user.UserTempData)
                .WithOne(userTempData => userTempData.User)
                .HasForeignKey<UserTempData>(userTempData => userTempData.Id);

        }
    }
}
