using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeeMessenger.Data.Entities;

namespace VeeMessenger.Data.EntityConfigurations
{
    public class UserTempDataConfiguration : IEntityTypeConfiguration<UserTempData>
    {
        public void Configure(EntityTypeBuilder<UserTempData> builder)
        {
            builder.ToTable("UsersTempData");
            builder.HasKey(userTempData => userTempData.Id);
        }
    }
}
