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

        }
    }
}
