using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_Assignment_EF_2.DB_Context
{
    /*7. Course_Inst (Junction Table) 
• Composite PK: (inst_ID, Course_ID). 
• inst_ID INT FK NOT NULL → references Instructor(ID). 
• Course_ID INT FK NOT NULL → references Course(ID). 
• evaluate INT NULL CHECK (evaluate BETWEEN 1 AND 10).
     */
    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public Instructor Instructor { get; set; } = null!;

        public int Course_ID { get; set; }
        public Course Course { get; set; } = null!;

        public string Evaluate { get; set; } = string.Empty;
    }
}
