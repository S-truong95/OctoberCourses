using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoberCourses.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Courses> Courses {get; set;}
    }
}
