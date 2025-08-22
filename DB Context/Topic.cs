using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_Assignment_EF_2.DB_Context
{
    /*5. Topic 
• ID INT PK. 
• Name NVARCHAR(100) NOT NULL UNIQUE.
     */
    public class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
