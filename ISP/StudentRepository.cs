using OCP;

namespace ISP;

public class StudentRepository : IStudentRepository
{
    public void AddCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void AddStudent(Student std)
    {
        //implementation code removed for better clarity
    }

    public void DeleteCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void DeleteStudent(Student std)
    {
        //implementation code removed for better clarity
    }

    public void EditCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void EditStudent(Student std)
    {
        //implementation code removed for better clarity
    }

    public IList<Course> GetAllCourse()
    {
        //implementation code removed for better clarity
        return new List<Course>();
    }

    public IList<Course> GetAllCourses(Student std)
    {
        //implementation code removed for better clarity
        return new List<Course>();
    }

    public IList<Student> GetAllStudents()
    {
        //implementation code removed for better clarity
        return new List<Student>();
    }

    public IList<Student> GetAllStudents(Course cs)
    {
        //implementation code removed for better clarity
        return new List<Student>();
    }

    public void SubscribeCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void UnSubscribeCourse(Course cs)
    {
        //implementation code removed for better clarity
    }
}