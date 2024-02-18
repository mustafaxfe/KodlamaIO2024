using KodlamaIO_homepage.Business.Abstract;
using KodlamaIO_homepage.DataAccess.Abstract;
using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.Business.Concrete;

public class CourseManager : ICourseService
{
    public ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {  
        _courseDal = courseDal; 
    }
    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    //public Course GetById(int id)
    //{
    //    return _courseDal.GetById(id);
    //}
}
