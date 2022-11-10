using System;
using System.Text;
namespace CourseWork.BLL
{
    [Serializable]
    public class Decanate
    {
        public List<Student> students = new List<Student>();
        public static int Hostels = 11;
        
        public List<Hostel> hostels = new List<Hostel>(Hostels);
        public string FirstName {  get;set;  }
        public string LastName { get; set; }
        public int Course { get; set; }
        public string ID { get; set; }
        public bool isInHostel;
        public int HostelNumber { get; set; }
        
        public Decanate(string firstName, string lastName, int course, string id, bool IsInHostel, int hostelNumber)
        {
            FirstName = firstName; LastName = lastName; Course = course;   ID = id;
            isInHostel = IsInHostel;
            if (hostelNumber > 11)
            {
                isInHostel = false;
            }
            else
            {
                isInHostel = true;
                HostelNumber = hostelNumber;
            }
            if(isInHostel == true)
            {
                hostels = new List<Hostel>(HostelNumber);
            }
            else
            {
                isInHostel = false;
            }
        }
        public string GetStudentInfo()
        {
            StringBuilder info = new StringBuilder();
            foreach (var student in students)
                info.Append(student.ToString());
            return info.ToString();
        }
        public string GetHostelInfo()
        {
            StringBuilder info = new StringBuilder();
            foreach (var hostel in hostels) 
                info.Append(hostel.ToString());
            
            return info.ToString();
        }
        public override string ToString()
        {
            return $"Student: {LastName} {FirstName}\n"+
                $"LastName: {LastName}\n"+
                $"FirstName: {FirstName}\n"+
                $"Info: {GetStudentInfo()}\n"+
                $"Hostel: {GetHostelInfo()}\n";
        }
    }
}