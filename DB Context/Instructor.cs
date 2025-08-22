using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_Assignment_EF_2.DB_Context
{
    /*4. Instructor 
• ID INT PK. 
• Name NVARCHAR(100) NOT NULL. 
• Salary DECIMAL(10,2) NOT NULL CHECK (Salary > 0). 
• Address NVARCHAR(150) NULL. 
• HourRateBouns DECIMAL(10,2) DEFAULT 0 CHECK (HourRateBouns >= 0). 
• Dept_ID INT FK NOT NULL → references Department(ID).
     */
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public decimal HourRateBouns { get; set; }

        public int Dept_ID { get; set; }
        public Department Department { get; set; } = null!;

        public ICollection<Course_Inst> CourseInstructors { get; set; } = new List<Course_Inst>();
    }
}
