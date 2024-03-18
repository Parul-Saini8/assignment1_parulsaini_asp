using Microsoft.EntityFrameworkCore;
using ImperialRulers.Models;

namespace ImperialRulers.Data
{
    public class ImperialRulersContext : DbContext
    {
        public ImperialRulersContext(DbContextOptions<ImperialRulersContext> options)
            : base(options)
        {
        }

        public DbSet<Ruler> Ruler { get; set; }
    }
}