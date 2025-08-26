using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_Assignment_EF_2.DB_Context
{/*6. Stud_Course (Junction Table) 
• Composite PK: (stud_ID, Course_ID). 
• stud_ID INT FK NOT NULL → references Student(ID). 
• Course_ID INT FK NOT NULL → references Course(ID). 
• Grade INT CHECK (Grade BETWEEN 0 AND 100).
  */
    public class Stud_Course
    {
        public int Stud_ID { get; set; }
        public Student Student { get; set; } =null!;

        public int Course_ID { get; set; }
        public Course Course { get; set; } = null!;

        public decimal Grade { get; set; }
    }
}
