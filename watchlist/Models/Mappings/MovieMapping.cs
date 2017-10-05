using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Watchlist.Models.Mappings
{
	public class MovieMapping
	{
		public MovieMapping (EntityTypeBuilder<Movie> builder)
		{
			builder
				.ToTable("Movies");

			builder
				.HasKey(m => m.Id)
				.ValueGeneratedOnAdd();
			
			builder
				.Property(m => m.Id)
				.IsRequired()
				.HasMaxLength(255);

			builder
				.Property(m => m.Image)
				.HasMaxLength(255);

			builder
				.Property(m => m.Title)
				.IsRequired()
				.HasMaxLength(255);

			builder
				.HasOne(m => m.Movies)
				.WithMany(u => u.User)
				.HasForeignKey(u => u.UserId);
		}
	}
}