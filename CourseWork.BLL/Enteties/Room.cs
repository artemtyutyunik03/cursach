using System.Runtime.Serialization;

namespace CourseWork.BLL
{
    [DataContract]
    [KnownType(typeof(List<object>))]
    [KnownType(typeof(Student))]
    public class Room
    {
        public int number { get;}

        private List<Student> studentsInHostel;
        
        private int limit;
        
        public int count { get; set;}

        public Room()
        {

        }
        
        public Room(int Number, int Limit)
        {
            number = Number;
            count = 0;
            limit = Limit;
            studentsInHostel = new List<Student>();
        }
        
        public void SetAccommodationStudent(Student Student)
        {
            studentsInHostel.Add(Student);
            count = studentsInHostel.Count;
        }
        public List<Student> GetStudentsInHostel()
        {
            return studentsInHostel;
        }  
        public void DischargeStudent(Student Student)
        {
            studentsInHostel.Remove(Student);
            count--;
        }
        
        public int avaibleCount()
        {
            return limit - count;
        }

        public override string ToString()
        {
            return  "\nRoom:\nNumberOfRoom: " + number + 
                    "\nNumber of Students at room:" + count + 
                    "\nFree places in room: " + avaibleCount() + "\n";

        }
    }
}