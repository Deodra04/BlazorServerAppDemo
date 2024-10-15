using Microsoft.EntityFrameworkCore;
namespace BlazorServerAppDemo.Data
{
    public class AppDBContext :DbContext
    {
        public DbSet<Member> Members { get; set; }
        public string connectionString { get; }
        public AppDBContext()
        {
            connectionString = "Data Source = (LocalDb)\\MSSQLLocalDB;Initial Catalog = TestDB;Integrated Security =True";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);  // to set up DB connection                                                            
        }
    }
}
