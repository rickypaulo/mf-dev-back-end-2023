using Microsoft.EntityFrameworkCore;

namespace mf_dev_back_end_2023.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
