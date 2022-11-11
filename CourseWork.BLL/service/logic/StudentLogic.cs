using XMLProvider.DAL;

namespace CourseWork.BLL
{
    public class StudentLogic
    {
        private static string filePath = "student.xml";
        
        public static void AddStudent(string name,string surname,int course,string ID, string groupName)
        {
            List<Student> list = API.GetInfo<Student>(filePath);
            Student student = new Student(name, surname, course, ID, groupName);
            list.Add(student);
            API.PostInfo<Student>(list, filePath);
        }
        
        public static void DeleteStudent(string ID)
        {
            List<Student> list = API.GetInfo<Student>(filePath);
            foreach (Student student in list.ToList())
            {
                if (ID == student.ID) list.Remove(student);
            }
            API.PostInfo<Student>(list, filePath);
        }
        public static void ChangeStudentData(string ID, string NewName,string NewSurname,int course,string newGroup)
        {
            List<Student> list = API.GetInfo<Student>(filePath);
            foreach (Student student in list)
            {
                if (ID == student.ID)
                {
                    student.FirstName = NewName;
                    student.LastName = NewSurname;
                    student.Course = course;
                    student.NameOfGroup = newGroup;
                }
            }
            API.PostInfo<Student>(list, filePath);
        }
        public static string GetAllStudents()
        {
            string data = "";
            List<Student> list = API.GetInfo<Student>(filePath);
            foreach (Student student in list)
            {
                data += student.ToString();
            }
            return data;
        }
        public static string getStudentByID(string ID)
        {
            string response = "";
            List<Student> list = API.GetInfo<Student>(filePath);
            foreach (Student student in list)
            {
                if (ID == student.ID)
                {
                    response =  student.ToString();
                    break;
                }
                else
                {
                    response = "Current student is not exist";
                }
            }
            return response;
        }
    }
}

