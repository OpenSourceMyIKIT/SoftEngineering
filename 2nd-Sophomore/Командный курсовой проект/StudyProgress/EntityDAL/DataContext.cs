using System.Data.Entity;
using SharedModel;

namespace EntityDAL
{
    internal class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Term> Terms { get; set; }

        public DataContext()
            : base(@"Data Source=dns\sqlexpress;Initial Catalog=SPdb4;Integrated Security=True")
        { }
    }
}
