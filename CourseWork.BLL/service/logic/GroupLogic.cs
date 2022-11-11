using XMLProvider.DAL;


namespace CourseWork.BLL
{
    public static class GroupLogic
    {
        private static string filePath = "group.xml";
        
        public static void AddGroup(int course,string nameOfGroup)
        {
            List<Group> list = API.GetInfo<Group>(filePath);
            Group group = new Group( course, nameOfGroup);
            list.Add(group);
            API.PostInfo<Group>(list, filePath);
        }
        
        public static void DeleteGroup(string Name)
        {
            List<Group> list = API.GetInfo<Group>(filePath);
            foreach (Group gr in list.ToList())
            {
                if (Name == gr.NameOfGroup) list.Remove(gr);
            }
            API.PostInfo<Group>(list, filePath);
        }
        
        public static void ChangeGroupData(string prevName, int newCourse,string newNameOfGroup)
        {
            List<Group> list = API.GetInfo<Group>(filePath);
            foreach (Group gr in list)
            {
                if (prevName == gr.NameOfGroup)
                {
                    gr.NameOfGroup = newNameOfGroup;
                    gr.Course = newCourse;
                }
            }
            API.PostInfo<Group>(list, filePath);
               
        }
        
        public static string GetGroupByName(string Name)
        {
            string result = "";
            List<Student> students = new List<Student>();
            List<Group> list = API.GetInfo<Group>(filePath);
            foreach (Group gr in list)
            {
                if (Name == gr.NameOfGroup)
                {
                    students = gr.getGroupList();
                    string studentInfo = null;
                    foreach (Student st in students)
                    {
                        studentInfo += "Name:\t" + st.FirstName + "\nSurname:\t" + st.LastName + "\n";
                    }
                    result = "GroupName:\t" + gr.NameOfGroup + "\nCourse:\t" + gr.Course + "\nStudents:\t\n" + studentInfo + "\n";
                    break;
                }
                else
                {
                    result = "Current group is not exist";
                }
            }
            return result;
        }

        public static void AddStudentToGroup(string GroupName, string ID)
        {
            List<Group> listG = API.GetInfo<Group>(filePath);
            List<Student> listL = API.GetInfo<Student>("student.xml");
            
            foreach (Student student in listL.ToList())
            {
                if (ID == student.ID)
                {
                    foreach (Group gr in listG.ToList())
                    {
                        if (gr.NameOfGroup == GroupName)
                        {
                            gr.AddStudentInList(student);
                        }
                    }
                }
            }
            API.PostInfo<Group>(listG, filePath);
        }
        
        public static void RemoveStudentFromGroup(string GroupName, string ID)
        {
            List<Group> list = API.GetInfo<Group>(filePath);
            foreach (Group gr in list.ToList())
            {
                if (GroupName == gr.NameOfGroup)
                {
                    List<Student> students = new List<Student>();
                    students = gr.getGroupList();
                    
                    foreach (Student student in students.ToList())
                    {
                        if (ID == student.ID)
                        {
                            gr.RemoveStudentInList(student);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            API.PostInfo<Group>(list, filePath);
        }
    }
}