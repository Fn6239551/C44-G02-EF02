using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_Assignment_EF_2.DB_Context
{
    /*2. Department 
• ID INT PK. 
• Name NVARCHAR(100) NOT NULL UNIQUE. 
• Ins_ID INT FK NULL → references Instructor(ID) (department head). 
• HiringDate DATE NOT NULL CHECK (HiringDate <= GETDATE()).
     */
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
       

        public DateTime HiringDate { get; set; }

        public int? Ins_ID { get; set; }
        public Instructor? Head { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
    }
}
