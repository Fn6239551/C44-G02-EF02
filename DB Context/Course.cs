using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_Assignment_EF_2.DB_Context
{/*3. Course 
• ID INT PK. 
• Duration INT NOT NULL CHECK (Duration > 0). 
• Name NVARCHAR(100) NOT NULL UNIQUE. 
• Description NVARCHAR(255) NULL. 
• Top_ID INT FK NOT NULL → references Topic(ID).
  */
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public int Top_ID { get; set; }
        public Topic Topic { get; set; } = null!;

        public ICollection<Stud_Course> StudCourses { get; set; } = new List<Stud_Course>();
        public ICollection<Course_Inst> CourseInstructors { get; set; } = new List<Course_Inst>();
    }
}
