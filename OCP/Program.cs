
using OCP;

Student student = new Student { FirstName = "Ion", LastName = "Creanga", Email = "nicacreanga@gmail.com" };

Course onlineSoftwareEngCourse = new Course() {Type = "online", Title = "Software Course", Language = "Eng" };

onlineSoftwareEngCourse.Subscribe(student);