namespace CourseWork.BLL
{
    [Serializable]
    public class Hostel
    {
        public int HostelNumber { get; set; }
        public int Flour { get; set; }
        public string NumberOfRoom { get; set; }
        public int LiveIn { get; set; }

        public bool isAvaliable;
        
        public Hostel(int flour,string numberOfRoom,int liveIn,int hostelNumber) 
        { Flour = flour;
            NumberOfRoom = numberOfRoom;
            if (liveIn > 4)
            {
                isAvaliable = false;
            }
            else
            {
                isAvaliable = true;
                LiveIn = liveIn;
            }

            HostelNumber = hostelNumber;
        }
        
        public override string ToString() {
            return $"Hostel: {HostelNumber}\n"+
                   $"Flour: {Flour}\n" + 
                   $"Room: {NumberOfRoom}\n" +
                   $"Members: {LiveIn}";
        }
    }
}

