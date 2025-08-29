using Solv_Assignment_EF_2.Data;
using Solv_Assignment_EF_2.DB_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Solv_Assignment_EF_2
{
    public static class JsonSeeder
    {
        public static void SeedFromJson(ItiDbContext context)
        {
            // Seed Departments
            if (!context.Departments.Any())
            {
                var departmentsJson = File.ReadAllText("departments.json");
                var departments = JsonSerializer.Deserialize<List<Department>>(departmentsJson);
                context.Departments.AddRange(departments!);
            }

            // Seed Instructors
            if (!context.Instructors.Any())
            {
                var instructorsJson = File.ReadAllText("instructors.json");
                var instructors = JsonSerializer.Deserialize<List<Instructor>>(instructorsJson);
                context.Instructors.AddRange(instructors!);
            }

            context.SaveChanges();
        }
    
}
}
