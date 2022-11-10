using System;
using System.Text.RegularExpressions;

namespace CourseWork.PL
{
    public class MenuAPI
    {
        public static void ChooseManagment()
        {
            Console.WriteLine("\nMENU\nChoose managment option: \n1 => Student Management\n2 => Group Management\n3 => Managing the settlement in the hostel\n4 => Search");
        }
        
        public static void StudentManagment()
        {
            Console.WriteLine("\nChoose Student Management option:\n" + 
            "\t1 => Ability to add student\n" + 
            "\t2 => Ability to delete student\n" +
            "\t3 => Ability to change student data\n" +
            "\t4 => The ability to view a list of all students\n"+
            "\t5 => Ability to view data from a specified student\n");
        }
        public static void GroupManagment()
        {
            Console.WriteLine("\nChoose Group Management option:\n" + 
            "\t1 => Ability to add group\n" + 
            "\t2 => Delete Group option\n" + 
            "\t3 => Ability to modify group data\n" + 
            "\t4 => Ability to view a list of group data\n" + 
            "\t5 => Ability to view specific group data\n" + 
            "\t6 => Ability to add a student to an existing group\n" + 
            "\t7 => Ability to remove student from existing group\n");
        }
        public static void HostelManagment()
        {
            Console.WriteLine("\nChoose Hostel Management option:\n" + 
            "\t1 => Possibility to add the data about the hostel (rooms, maximum number of tenants(renters)\n" + 
            "\t2 => Possibility of changing the hostel data\n" + 
            "\t3 => The possibility of student accommodation in the hostel\n" + 
            "\t4 => Possibility of discharge of student from dormitory\n" + 
            "\t5 => Possibility to receive information about residents in general, free places in the rooms.\n");
        }
        public static void SearchManagment()
        {
            Console.WriteLine("\nChoose Search option:\n" + 
            "\t1 => Ability to search for a student according to his data (full name)\n" +
            "\t2 => Ability to find students in a particular group\n" +
            "\t3 => The ability to search students in a hostel");
        }

        //Student info
        //Name, Surname, YearOfStudy, Speciality
        public static void InputName(out string Name)
        {
            while (true)
            {
                Console.WriteLine("Enter Name:");
                Name = Console.ReadLine();
                if (Regex.IsMatch(Name, @"^[A-Z][a-z]{2,20}$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }
        public static void InputSurname(out string Surname)
        {
            while (true)
            {
                Console.WriteLine("Enter Surname:");
                Surname = Console.ReadLine();
                if (Regex.IsMatch(Surname, @"^[A-Z][a-z]{2,20}$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }
        public static void InputYearOfStudy(out string YearOfStudy)
        {
            while (true)
            {
                Console.WriteLine("Enter Year Of Study:");
                YearOfStudy = Console.ReadLine();
                if (Regex.IsMatch(YearOfStudy, @"^[1-9]$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }
        public static void InputSpeciality(out string Speciality)
        {
            while (true)
            {
                Console.WriteLine("Enter Speciality:");
                Speciality = Console.ReadLine();
                if (Regex.IsMatch(Speciality, @"^[A-Z][a-z]{2,20}$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }

        //Group info
        //YearOfStudy, Speciality taking from "Student info"
        public static void InputGroupName(out string GroupName)
        {
            while (true)
            {
                Console.WriteLine("Enter GroupName:");
                GroupName = Console.ReadLine();
                if (Regex.IsMatch(GroupName, @"^[A-Z][a-z]{2,20}$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }
        //Hostel info
        //NumberOfHostel, NumberOfRooms, Limit
        public static void InputNumberOfHostel(out string NumberOfHostel)
        {
            while (true)
            {
                Console.WriteLine("Enter Number Of Hostel:");
                NumberOfHostel = Console.ReadLine();
                if (Regex.IsMatch(NumberOfHostel, @"^[1-9]+")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }
        public static void InputNumberOfRoom(out string NumberOfRoom)
        {
            while (true)
            {
                Console.WriteLine("Enter Number Of Room:");
                NumberOfRoom = Console.ReadLine();
                if (Regex.IsMatch(NumberOfRoom, @"^[1-9]+")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }
        public static void InputNumberOfRooms(out string NumberOfRooms)
        {
            while (true)
            {
                Console.WriteLine("Enter Max Number Of Rooms:");
                NumberOfRooms = Console.ReadLine();
                if (Regex.IsMatch(NumberOfRooms, @"^[1-9]+$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }
        public static void InputLimitInRoom(out string LimitInRoom)
        {
            while (true)
            {
                Console.WriteLine("Enter the Limit in room:");
                LimitInRoom = Console.ReadLine();
                if (Regex.IsMatch(LimitInRoom, @"^[1-9]+$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
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