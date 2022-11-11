using XMLProvider.DAL;

namespace CourseWork.BLL
{
    public class HostelLogic
    {
        private static string filePath = "hostel.xml";
        
        public static void AddHostel(int hostelNumber, int flour,int numberOfRoom,int liveIn)
        {

            List<Hostel> list = API.GetInfo<Hostel>(filePath);
            Hostel hostel = new Hostel(hostelNumber, flour, numberOfRoom, liveIn);
            list.Add(hostel);
            API.PostInfo<Hostel>(list, filePath);

        }
        
        public static void ChangeHostelData(int NumberOfHostel, int NewNumber)
        {
           
            List<Hostel> list = API.GetInfo<Hostel>(filePath);
            foreach (Hostel student in list)
            {
                if (NumberOfHostel == student.HostelNumber)
                {
                    student.HostelNumber = NewNumber;
                }
            }
            API.PostInfo<Hostel>(list, filePath);
        }

        public static string GetInfoByNumber(int NumberOfHostel)
        {
            string result = "";
            List<Hostel> hostels = API.GetInfo<Hostel>(filePath);
            foreach (Hostel hostel in hostels)
            {
                if (NumberOfHostel == hostel.HostelNumber)
                {
                    List<Room> roomList = hostel.GetRoomList();
                    foreach ( Room room in roomList.ToList())
                    {
                        result += room.ToString();
                    }
                }
            }
            return result;
        }
        
        public static void AddStudentToHostel(int NumberOfHostel,int RoomNumber, string ID)
        {
            List<Hostel> hostels = API.GetInfo<Hostel>(filePath);
            List<Student> students = API.GetInfo<Student>("student.xml");
            List<Room> rooms = new List<Room>();
            
            foreach (Student student in students.ToList())
            {
                if (ID == student.ID)
                {
                    foreach(Hostel hl in hostels)
                    {
                        if(NumberOfHostel == hl.HostelNumber)
                        {
                            rooms = hl.GetRoomList();
                            foreach (Room room in rooms)
                            {
                                if (RoomNumber == room.number)
                                {
                                
                                    room.SetAccommodationStudent(student);
                                }
                            }
                        }
                    }
                }
            }
            
            API.PostInfo<Hostel>(hostels, filePath);
        }
        
        public static void RemoveStudentFromHostel(int NumberOfHostel,int NumberOfRoom, string StudentName, string Surname)
        {
            List<Hostel> hostels = API.GetInfo<Hostel>(filePath);
            
            foreach (Hostel hostel in hostels.ToList())
            {
                if (NumberOfHostel == hostel.HostelNumber)
                {
                    List<Room> rooms = new List<Room>();
                    rooms = hostel.GetRoomList();
                    foreach (Room room in rooms.ToList())
                    {
                        if (NumberOfRoom == room.number)
                        {
                            List<Student> student = new List<Student>();
                            student = room.GetStudentsInHostel();
                            foreach (Student st in student.ToList())
                            {

                                if (StudentName == st.FirstName && Surname == st.LastName)
                                {
                                    room.DischargeStudent(st);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            API.PostInfo<Hostel>(hostels, filePath);
        }
    }

}
