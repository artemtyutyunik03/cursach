namespace CourseWork.BLL
{[Serializable]
    public class Group
    {
        public int Course { get; set; }
        public string NameOfGroup { get; set; }

        private List<Student> _groupList;

        public Group()
        {
            _groupList = new List<Student>();
        }
        
        public Group(int course, string nameOfGroup)
        {
            Course = course;
            NameOfGroup = nameOfGroup;
            _groupList = new List<Student>();
        }

        public List<Student> getGroupList()
        {
            return _groupList;
        }
        
        public void AddStudentInList(Student student)
        {
            _groupList.Add(student);
        }
        public void RemoveStudentInList(Student student)
        {
            _groupList.Remove(student);
        }
        
        
        

        public override string ToString()
        {
            return $"{NameOfGroup}\n";
        }

    }
    
}
