namespace Mvc7_Pillars.Data
{
    public class FriendContext : DbContext
    {
        public FriendContext(DbContextOptions<FriendContext> options):base(options)
        {
        }

        public DbSet<Friend> Friends { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
