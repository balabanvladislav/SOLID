namespace OCP;

public class EmailManager
{
    public static void SendEmailConfirmation(string studentEmail, Course course)
    {
        // send email functionality..
        Console.WriteLine($"Email confirmation was sens to {studentEmail}, student is now enrolled in the {course.Type} course ,,{course.Title},,");
    }
}