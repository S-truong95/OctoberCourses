using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OctoberCourses.Models;

namespace OctoberCourses.Repositories
{
    public class CourseRepository : IRepository<Courses>
    {
        public List<Courses> coursesList;

        public CourseRepository()
        {
            coursesList = new List<Courses>()
            {
            new Courses(1, "Machine Learning", "No, Don't let the machines learn anything"),
            new Courses(2, "C# for Dummies", "This book series is insulting"),
            new Courses(3, "HTML, CSS, JVS", "Web Design")

            };

        }

        public IEnumerable<Courses> GetAll()
        {
            return coursesList;
        }

        public Courses GetById(int id)
        {
            return coursesList.Single(c => c.Id == id);
        }
    }
}
