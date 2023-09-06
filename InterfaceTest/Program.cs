using System;
using System.Diagnostics;

public interface ICourse
{
    public int CourseCode { get; set; }
    public string CourseName { get; set; }
    public int CreditHour { get; set; }
}
class Course:ICourse
{
    public int CourseCode
    {
        get; set; 
    }
    public string CourseName 
    {
        get; set; 
    }
    public int CreditHour 
    { 
        get; set;
    }
    public Course(int CourseCode,string CourseName,int CreditHour)
    {
        this.CourseCode = CourseCode;
        this.CourseName = CourseName;
        this.CreditHour = CreditHour;

    }
    public void printing()
    {
        Console.WriteLine("CourseCode" + CourseCode + "CourseName" + CourseName + "CreditHour" + CreditHour +);
    }
}

public interface IStudent
{
    public int StudentID  {   get; set;  }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string RegisterCourse { get; set; }
}
class Student : IStudent
{
    public int StudentID
    {
        get; set;
    }
    public string FirstName
    {
        get; set;
    }
    public string LastName
    {
        get; set;
    }
    public string RegisterCourse
    {
        get; set;
    }
    public Student(int StudentID, string FirstName, String LastName, string RegisterCourse)
    {
        this.StudentID = StudentID;
        this.FirstName = FirstName;
        this.LastName =LastName;
        this.RegisterCourse = RegisterCourse;

    }
    public void printing()
    {
        Console.WriteLine("StudentID" + StudentID + "FirstName" + FirstName+ "LastName" + LastName + "RegisterCourse"+RegisterCourse+);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Course c = new Course(1," usha gurung", 10);
        c.printing();
            Student s = new Student(2, "usha", "gurung", "visual programming");
        s.printing();

    }
}