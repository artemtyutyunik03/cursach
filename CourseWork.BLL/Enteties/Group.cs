namespace CourseWork.BLL
{[Serializable]
    public class Group
    {
        public int Course { get; set; }
        public string NameOfGroup { get; set; }
        public Group(int course,string nameOfGroup) { Course = course;NameOfGroup = nameOfGroup; }
        
        public override string ToString()
        {
            return $"Group: {NameOfGroup}\n"+
                   $"Course: {Course}\n";
        }

    }
    
}
