using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_Assignment_EF_2.DB_Context
{
    /*1. Student 
        • ID INT PK (Primary Key). 
        • FName NVARCHAR(50) NOT NULL. 
        • LName NVARCHAR(50) NOT NULL. 
        • Address NVARCHAR(150) NULL. 
        • Age INT NOT NULL CHECK (Age BETWEEN 18 AND 60). 
        • Dep_Id INT FK NOT NULL → references Department(ID).
     */
    public class Student
    {
        public int Id { get; set; }
       
        public string? FName { get; set; }

        public string? LName { get; set; }

        public string? Address { get; set; }
        public int Age { get; set; }

        public int Dep_Id { get; set; }
        public Department Department { get; set; } = null!;

        public ICollection<Stud_Course> StudCourses { get; set; } = new List<Stud_Course>();

    }
}
