using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace OctoberCourses.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual int InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; }

        public Courses()
        {

        }

        public Courses(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;

        }
    }
}
