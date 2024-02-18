// See https://aka.ms/new-console-template for more information
using KodlamaIO_homepage.Business.Concrete;
using KodlamaIO_homepage.DataAccess.Abstract;
using KodlamaIO_homepage.DataAccess.Concrete;
using KodlamaIO_homepage.Entities.Concrete;
using System.Collections;
Tutor tutor1 = new Tutor()
{
    TutorId = 1001,
    TutorName = "Engin",
    TutorDescription = "Lead Instructor",
    TutorUrl = null
};
Tutor tutor2 = new Tutor()
{
    TutorId = 1002,
    TutorName = "Mustafa",
    TutorDescription = "Instructor",
    TutorUrl = null
};
Tutor tutor3 = new Tutor()
{
    TutorId = 1003,
    TutorName = "Eren",
    TutorDescription = "Instructor",
    TutorUrl = null
};
Category category1 = new Category()
{
    CategoryId = 111,
    CategoryName = "C#",
};
Category category2= new Category()
{
    CategoryId = 112,
    CategoryName = "Python",
};
Category category3 = new Category()
{
    CategoryId = 113,
    CategoryName = "Java",
};
Course course1 = new Course()
{
    CourseId = 1112,
    CourseName = "C# Camp 2024",
    CourseDescription = "Live camp",
    CourseTitle = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)"
};
Course course2 = new Course()
{
    CourseId = 1113,
    CourseName = "C# Camp 2021",
    CourseDescription = "(C# + ANGULAR)",
    CourseTitle = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)"
};
Course course3= new Course()
{
    CourseId = 1114,
    CourseName = "Java Camp 2022",
    CourseDescription = "Java",
    CourseTitle = "(2022) Java Yazılım Geliştirici Yetiştirme Kamp"
};
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
TutorManager tutorManager = new TutorManager(new TutorDal());
CourseManager courseManager = new CourseManager(new CourseDal());
Console.WriteLine("****** Categories ******");
categoryManager.Add(category1);
categoryManager.Add(category2);
categoryManager.Add(category3);
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine("Category Name: {0}, Catgory ID: {1} ",category.CategoryName, category.CategoryId);
}
categoryManager.Remove(category1);
Console.WriteLine("****** Categories ******");
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine("New Categories -> Category Name: {0}, Catgory ID: {1} ", category.CategoryName, category.CategoryId);
}
Console.WriteLine("****** Instructors ******");
tutorManager.Add(tutor1);
tutorManager.Add(tutor2);
tutorManager.Add(tutor3);
foreach (var tutor in tutorManager.GetAll())
{
    Console.WriteLine("Insructor Name: {0}, Instructor ID: {1} ", tutor.TutorName, tutor.TutorId);
}
tutorManager.Delete(tutor1);
Console.WriteLine("****** Instructors ******");

foreach (var tutor in tutorManager.GetAll())
{
    Console.WriteLine("New Instructors -> Insructor Name: {0}, Instructor ID: {1} ", tutor.TutorName, tutor.TutorId);
}
Console.WriteLine("****** Courses ******");

courseManager.Add(course1);
courseManager.Add(course2);
courseManager.Add(course3);
foreach (var course in courseManager.GetAll())
{
    Console.WriteLine("Course Name: {0}, Course ID: {1}, Title of course {2} ", course.CourseName, course.CourseId, course.CourseTitle);
}
courseManager.Delete(course1);
Console.WriteLine("****** Courses ******");
foreach (var course in courseManager.GetAll())
{
    Console.WriteLine("New Courses -> Course Name: {0}, Course ID: {1}, Title of course {2} ", course.CourseName, course.CourseId, course.CourseTitle);
}