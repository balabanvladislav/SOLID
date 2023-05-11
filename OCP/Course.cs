namespace OCP;

public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Language { get; set; }
    public string Type { get; set; }

    public void Subscribe(Student student)
    {
        Logger.Log("Starting Subscribe()");

        //apply business rules based on the course type live, online, offline, if any 
        if (this.Type == "online")
        {
            // code to subscribe to online course 
        }
        else if (this.Type == "offline")
        {
            // code to subscribe to offline course 
        }

        // payment processing
        PaymentManager.ProcessPayment();

        //create CourseRepository class to save student and course into StudentCourse table  

        // send confirmation email
        EmailManager.SendEmailConfirmation(student.Email, this);

        Logger.Log("End Subscribe()");
    }
}