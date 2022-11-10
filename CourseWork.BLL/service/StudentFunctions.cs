using XMLProvider;

namespace CourseWork.BLL
{
    public class StudentFunctions
    {
        private static string filePath = "student.xml";
        
        public static void AddStudent(string Name,string Surname,int YearOfStudy,string Speciality)
        {
            List<Student> list = API.ReadInfo<Student>(filePath);
            Student student = new Student(Name, Surname, YearOfStudy, Speciality, "some");
            list.Add(student);
            API.WriteInfo<Student>(list, filePath);
        }
    }
}

