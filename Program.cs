using Solv_Assignment_EF_2.Data;

namespace Solv_Assignment_EF_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ItiDbContext();
            JsonSeeder.SeedFromJson(context);
            Console.WriteLine("Database seeded successfully!");

            #region Part 01
            #region Explicit Loading
            // Load related entities manually using .Entry().Collection(...).Load()
            // or .Entry().Reference(...).Load(). Useful for precise control, but may 
            // cause multiple queries if used many times.
            #endregion

            #region Eager Loading
            // Load related entities at the same time as the main entity using .Include().
            // Brings everything in one query. Good for performance when you know you'll 
            // need the related data, but may fetch unnecessary data.
            #endregion

            #region Lazy Loading
            // Related data is loaded automatically when accessed for the first time.
            // Requires virtual navigation properties and proxies. Very convenient, but 
            // can cause the N+1 query problem (too many small queries).
            #endregion

            #region Cross Join
            // Combines every row from one table with every row from another (Cartesian product).
            // Implemented in LINQ with multiple "from" clauses. Can produce huge results.
            #endregion

            #endregion
        }
    }
}
