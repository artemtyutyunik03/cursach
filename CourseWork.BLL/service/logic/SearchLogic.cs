using XMLProvider.DAL;


namespace CourseWork.BLL
{
    public class SearchFunction
    {
        public static string SearchStudentByID(string ID)
        {
            string result = "";
            List<Student> Students = API.GetInfo<Student>("student.xml");
            
            foreach (Student student in Students)
            {
                if (ID == student.ID)
                {
                    result += student.ToString();
                    break;
                }
                else
                {
                    result += "There`s no a such student";
                }
            }

            return result;
        }

        public static string SearchStudentByGroupName(string GroupName, string ID)
        {
            string result = "";
            List<Group> groups = API.GetInfo<Group>("group.xml");
            List<Student> students = new List<Student>();
            foreach (Group gr in groups)
            {
                if (gr.NameOfGroup == GroupName)
                {
                    students = gr.getGroupList();
                    foreach (Student st in students)
                    {
                        if (ID == st.ID)
                        {
                            result += st.ToString();
                            break;
                        }
                        else
                        {
                            result = "There`s no a such student";
                            break;
                        }
                    }
                }
                
            }

            return result;
        }
    }
}
