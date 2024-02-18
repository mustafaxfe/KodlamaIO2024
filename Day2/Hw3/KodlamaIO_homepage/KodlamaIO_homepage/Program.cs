// See https://aka.ms/new-console-template for more information
using KodlamaIO_homepage.Business.Concrete;
using KodlamaIO_homepage.DataAccess.Abstract;
using KodlamaIO_homepage.DataAccess.Concrete;
using KodlamaIO_homepage.Entities.Concrete;
using System.Collections;
Tutor tutor = new Tutor()
{
    TutorId = 10,
    TutorName = "Engin",
    TutorDescription = "Lead Instructor",
    TutorUrl = null
};
Tutor tutor2 = new Tutor()
{
    TutorId = 11,
    TutorName = "Mustafa",
    TutorDescription = "Instructor",
    TutorUrl = null
};
Category category1 = new Category()
{
    CategoryId = 1,
    CategoryName = "C#",
};
Category category2= new Category()
{
    CategoryId = 1,
    CategoryName = "C#",
};
Course course1 = new Course()
{
    CourseId = 12,
    CourseName = "C# Camp",
    CourseDescription = "Live camp",
    CourseTitle = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)"
};
Course course2 = new Course()
{
    CourseId = 123,
    CourseName = "C# Camp 2021",
    CourseDescription = "(C# + ANGULAR)",
    CourseTitle = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)"
};

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
TutorManager tutorManager = new TutorManager(new TutorDal());
CourseManager courseManager = new CourseManager(new CourseDal());



