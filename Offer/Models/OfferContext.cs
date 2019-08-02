using Microsoft.EntityFrameworkCore;

namespace Offer.Models
{
    public class OfferContext:DbContext
    {
        public OfferContext(DbContextOptions<OfferContext> opts) : base(opts) { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Postcode> Postcodes { get; set; }
        public DbSet<EOffer> Offers { get; set; }
    }
}
