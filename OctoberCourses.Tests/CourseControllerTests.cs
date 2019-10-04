using System;
using System.Collections.Generic;
using System.Text;
using OctoberCourses.Models;
using OctoberCourses.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace OctoberCourses.Tests
{
    public class CourseControllerTests
    {
        CourseController underTest;
        
  

        [Fact]
        public void IndexReturnsAView()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void IndexPassesCourseModelToView()
        {
            var result = underTest.Index();

            Assert.IsType<List<Courses>>(result.Model);
        }
    }
}
