namespace CourseWork.PL
{
    public class MenuAPI
    {
        public static void ChooseManagment()
        {
            Console.WriteLine("\nMENU\nChoose  option: " +
                              "\n1:Student managing" +
                              "\n2: Group managing" +
                              "\n3: Hostel managing" +
                              "\n4: Search what you need");
        }
        
        public static void StudentManagment()
        {
            Console.WriteLine("\nChoose Student Management option:\n" + 
            "\t1: add student\n" + 
            "\t2: delete student\n" +
            "\t3: change student data\n" +
            "\t4: get all students\n"+
            "\t5: get specified student by his ID number\n");
        }
        public static void GroupManagment()
        {
            Console.WriteLine("\nChoose Group Management option:\n" + 
            "\t1: add group\n" + 
            "\t2: delete Group \n" + 
            "\t3: change group data\n" +
            "\t4: get specific group data by its name\n" + 
            "\t5: add a student to an group\n" + 
            "\t6: remove student from existing group\n");
        }
        public static void HostelManagment()
        {
            Console.WriteLine("\nChoose Hostel Management option:\n" + 
            "\t1: add the data about the hostel\n" + 
            "\t2: change the hostel data\n" + 
            "\t3: student accommodation in the hostel\n" + 
            "\t4: discharge of student from dormitory\n" + 
            "\t5: get information about residents in general, free places in the rooms.\n");
        }
        public static void SearchManagment()
        {
            Console.WriteLine("\nChoose Search option:\n" +
                              "\t1: Ability to search for a student according to his data (full name)\n" +
                              "\t2: Ability to find students in a particular group\n");
        }
        
        

        public static void Continue(object ex)
        {
            if (ex != null)
            {
                Console.WriteLine((ex as Exception).Message);
            }
            Console.WriteLine("If you want to continue write - \"yes\", if not write - \"no\"");
        }

    }
}