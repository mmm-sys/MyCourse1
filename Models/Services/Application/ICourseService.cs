using System;
using System.Collections.Generic;
using MyCourse1.Models.ViewModels;

namespace MyCourse1.Models.Services.Application
{
    public interface ICourseService
    {
        List<CourseViewModel> GetCourses();
        CourseDetailViewModel GetCourse(int id);
    }

}