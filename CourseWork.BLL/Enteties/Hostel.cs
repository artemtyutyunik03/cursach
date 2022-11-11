namespace CourseWork.BLL
{
    [Serializable]
    public class Hostel
    {
        public int HostelNumber { get; set; }
        public int Flour { get; set; }
        public int NumberOfRoom { get; set; }
        public int LiveIn { get; set; }

        private List<Room> _roomList;

        public bool isAvaliable;
        
        public Hostel(int hostelNumber, int flour,int numberOfRoom,int liveIn) 
        { 
            Flour = flour;
            NumberOfRoom = numberOfRoom;
            _roomList = new List<Room>();

            for(int i = 1; i <= NumberOfRoom; i++)
            {
                _roomList.Add(new Room(i, liveIn));
            }

            HostelNumber = hostelNumber;
        }
        
        public List<Room> GetRoomList()
        {
            return _roomList;
        }
        
        public override string ToString() {
            return $"Hostel: {HostelNumber}\n"+
                   $"Flour: {Flour}\n" + 
                   $"Room: {NumberOfRoom}\n" +
                   $"Members: {LiveIn}";
        }
    }
}

