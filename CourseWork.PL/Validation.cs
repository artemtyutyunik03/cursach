using System.Text.RegularExpressions;

namespace CourseWork.PL
{
    public class ValidationRules
    {
          public static void InputName(out string Name)
        {
            while (true)
            {
                Console.WriteLine("name: \n example: Ivan" );
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
                Console.WriteLine("surname: \n example: Ivanov");
                Surname = Console.ReadLine();
                if (Regex.IsMatch(Surname, @"[A-Z][a-z]{2,20}$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }
        public static void InputCourse(out string course)
        {
            while (true)
            {
                Console.WriteLine("course:");
                course = Console.ReadLine();
                if (Regex.IsMatch(course, @"^[1-9]$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol!");
                }
            }
        }
        public static void InputID(out string ID)
        {
            while (true)
            {
                Console.WriteLine("ID of the student:");
                ID = Console.ReadLine();
                if (Regex.IsMatch(ID, @"^[0-9]{0,8}$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nyou can use only numbers and no more than 8 symbols");
                }
            }
        }
        
        public static void InputGroupName(out string GroupName)
        {
            while (true)
            {
                Console.WriteLine("group name: \n example: PI121");
                GroupName = Console.ReadLine();
                if (Regex.IsMatch(GroupName, @"[A-Z]{2,10}[0-9]{0,4}$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nyou can use only numbers and liters in upper register");
                }
            }
        }
        
        public static void InputNumberOfHostel(out string NumberOfHostel)
        {
            while (true)
            {
                Console.WriteLine("hostel number:");
                NumberOfHostel = Console.ReadLine();
                if (Regex.IsMatch(NumberOfHostel, @"^[1-9]{0,3}")) { break; }
                else
                {
                    Console.WriteLine("Error! \n you can use only numbers");
                }
            }
        }
        public static void InputNumberOfFloor(out string NumberOfFloor)
        {
            while (true)
            {
                Console.WriteLine("Enter floor number:");
                NumberOfFloor = Console.ReadLine();
                if (Regex.IsMatch(NumberOfFloor, @"^[1-9]+")) { break; }
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
                Console.WriteLine("room number:");
                NumberOfRoom = Console.ReadLine();
                if (Regex.IsMatch(NumberOfRoom, @"^[A-Z][1-9]+")) { break; }
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
                Console.WriteLine("amount of rooms at hostel");
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
                Console.WriteLine("max amount that can leave in the room:");
                LimitInRoom = Console.ReadLine();
                if (Regex.IsMatch(LimitInRoom, @"^[1-9]+$")) { break; }
                else
                {
                    Console.WriteLine("Error! \nWrong symbol! You can use only numbers");
                }
            }
        }
    }
    
}

