using OCP;

namespace ISP;

public interface IStudentRepository
{
    void AddStudent(Student std);
    void EditStudent(Student std);
    void DeleteStudent(Student std);

    void AddCourse(Course cs);
    void EditCourse(Course cs);
    void DeleteCourse(Course cs);

    void SubscribeCourse(Course cs);
    void UnSubscribeCourse(Course cs);
    IList<Student> GetAllStudents();
    IList<Student> GetAllStudents(Course cs);

    IList<Course> GetAllCourse();
    IList<Course> GetAllCourses(Student std);
}