using System;
using Xunit;
using OctoberCourses.Models;

namespace OctoberCourses.Tests
{
    public class OctoberCoursesTest
    {
        Courses undertest;
        public OctoberCoursesTest()
        {
            undertest = new Courses(42, "Course Name", "Description of Course");
        }

        

        [Fact]
        public void CourseConstructor_Sets_Name_On_Course_Model()
        {
            var result = undertest.Name;

            Assert.Equal("Course Name", result);
        }

        [Fact]
        public void CourseConstructor_Sets_ID()
        {
            var result = undertest.Id;

            Assert.Equal(42, result);
                
        }

        [Fact]
        public void CourseConstructor_Sets_Description()
        {
            var result = undertest.Description;

            Assert.Equal("Description of Course", result);
        }


    }
}
