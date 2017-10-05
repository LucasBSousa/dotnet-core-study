using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Watchlist.Models.Mappings
{
	public class UserMapping
	{
		public UserMapping (EntityTypeBuilder<User> builder)
		{
			builder
				.ToTable("Users");

			builder
				.HasKey(u => u.Id)
				.ValueGeneratedOnAdd();
			
			builder
				.Property(u => u.Id)
				.IsRequired()
				.HasMaxLength(200);

			builder
				.Property(u => u.Email)
				.IsRequired()
				.HasMaxLength(255);

			builder
				.HasMany(u => u.Movies)
				.WithOne(m => m.User)
				.HasForeignKey(m => m.UserId);
		}
	}
}