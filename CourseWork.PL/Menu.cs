using CourseWork.BLL;


namespace CourseWork.PL {
    public static class Menu
    {
        
        public static void Switcher()
        {
            bool state = true;
            int choice = -1;
            
            void CheckForContinue(string? str)
            {
                state =  str == "yes";
            }
            
            do
            {
                MenuAPI.ChooseManagment();
                choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                        {
                            MenuAPI.StudentManagment();
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                {
                                    ValidationRules.InputName(out var name);
                                    ValidationRules.InputSurname(out var surname);
                                    ValidationRules.InputCourse(out var course);
                                    ValidationRules.InputID(out var ID);
                                    ValidationRules.InputGroupName(out var groupName);

                                    Services.AddStudent(name, surname, Convert.ToInt32(course), ID, groupName);
                                    MenuAPI.Continue(null!);
                                    CheckForContinue(Convert.ToString(Console.ReadLine()));
                                }
                                    break;
                                case 2:
                                {
                                    ValidationRules.InputID(out var ID);

                                    Services.DeleteStudent(ID);
                                    
                                    MenuAPI.Continue(null!);
                                    CheckForContinue(Convert.ToString(Console.ReadLine()));
                                } 
                                    break;
                                case 3:
                                {
                                    ValidationRules.InputID(out var ID);
                                    ValidationRules.InputName(out var newName);
                                    ValidationRules.InputSurname(out var newSurname);
                                    ValidationRules.InputCourse(out var course);
                                    ValidationRules.InputGroupName(out var groupName);

                                    Services.ChangeStudentData(ID, newName, newSurname, Convert.ToInt32(course), groupName);
                                    
                                    MenuAPI.Continue(null!);
                                    CheckForContinue(Convert.ToString(Console.ReadLine()));
                                } 
                                    break;
                                case 4:
                                {
                                    Console.WriteLine(Services.GetAllStudents());
                                    
                                    MenuAPI.Continue(null!);
                                    CheckForContinue(Convert.ToString(Console.ReadLine()));
                                } 
                                    break;
                                case 5:
                                {
                                    ValidationRules.InputID(out var ID);
                                    Console.WriteLine(Services.getStudentByID(ID));
                                    
                                    MenuAPI.Continue(null!);
                                     CheckForContinue(Convert.ToString(Console.ReadLine()));
                                } 
                                    break;
                            }
                        } break;
                        case 2:
                        {
                            MenuAPI.GroupManagment();
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                {
                                    ValidationRules.InputGroupName(out var name);
                                    ValidationRules.InputCourse(out var course);

                                    Services.AddGroup(name, Convert.ToInt32(course));
                                    
                                    MenuAPI.Continue(null!);
                                     CheckForContinue(Convert.ToString(Console.ReadLine()));
                                }
                                    break;
                                case 2:
                                {
                                    ValidationRules.InputGroupName(out var name);

                                    Services.DeleteGroup(name);
                                    
                                    
                                    MenuAPI.Continue(null!);
                                    CheckForContinue(Convert.ToString(Console.ReadLine()));
                                } break;
                                case 3:
                                    {
                                        ValidationRules.InputGroupName(out var name);
                                        ValidationRules.InputName(out var newName);
                                        ValidationRules.InputCourse(out var course);

                                        Services.ChangeGroupData(name, newName, Convert.ToInt32(course)); 
                                        
                                        MenuAPI.Continue(null!);
                                        CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                case 4:
                                    {
                                        ValidationRules.InputGroupName(out var name);

                                        Console.WriteLine(Services.GetGroupByName(name));
                                        
                                        MenuAPI.Continue(null!);
                                         CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                case 5:
                                    {
                                        ValidationRules.InputGroupName(out var groupName);
                                        ValidationRules.InputID(out var ID);
                                        
                                        Services.AddStudentToGroup(groupName, ID);
                                        
                                        MenuAPI.Continue(null!);
                                         CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                case 6:
                                {
                                    ValidationRules.InputGroupName(out var groupName);
                                    ValidationRules.InputID(out var ID);
                                    
                                    Services.RemoveStudentFromGroup(groupName, ID);
                                    
                                    MenuAPI.Continue(null!);
                                    CheckForContinue(Convert.ToString(Console.ReadLine()));
                                        
                                } break;
                            }   
                        } break;
                        case 3:
                        {
                            MenuAPI.HostelManagment();
                            switch (Convert.ToInt32(Console.ReadLine()))
                                {
                                    case 1:
                                    {
                                        ValidationRules.InputNumberOfHostel(out var numberOfHostel);
                                        ValidationRules.InputNumberOfHostel(out var numberOfFloor);
                                        ValidationRules.InputNumberOfRooms(out var numberOfRooms);
                                        ValidationRules.InputLimitInRoom(out var limit);

                                        Services.AddHostel( Convert.ToInt32(numberOfHostel),  Convert.ToInt32(numberOfFloor),Convert.ToInt32(numberOfRooms),  Convert.ToInt32(limit));
                                         
                                        MenuAPI.Continue(null!);
                                        CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                    case 2:
                                    {
                                        ValidationRules.InputNumberOfHostel(out var numberOfHostel);
                                        ValidationRules.InputNumberOfHostel(out var newNumber);

                                        Services.ChangeHostelData(Convert.ToInt32(numberOfHostel), Convert.ToInt32(newNumber));
                                        
                                        MenuAPI.Continue(null!);
                                        CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                    case 3: {
                                        ValidationRules.InputID(out var ID);
                                        ValidationRules.InputNumberOfHostel(out var hostelNumber);
                                        ValidationRules.InputNumberOfRoom(out var roomNumber);

                                        Services.AddStudentToHostel( Convert.ToInt32(hostelNumber), Convert.ToInt32(roomNumber),ID);
                                      
                                        MenuAPI.Continue(null!);
                                        CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                    case 4:
                                    {
                                        ValidationRules.InputName(out var name);
                                        ValidationRules.InputSurname(out var surname);
                                        ValidationRules.InputNumberOfHostel(out var hostelNumber);
                                        ValidationRules.InputNumberOfRoom(out var roomNumber);

                                        Services.RemoveStudentFromHostel( Convert.ToInt32(hostelNumber), Convert.ToInt32(roomNumber), name, surname);
                                        
                                        MenuAPI.Continue(null!);
                                        CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                    case 5:
                                    {
                                        ValidationRules.InputNumberOfHostel(out var hostelNumber);
                                        Console.WriteLine(Services.GetInfoByNumber( Convert.ToInt32(hostelNumber)));
                                        
                                        MenuAPI.Continue(null!);
                                        CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                }
                        }
                        break;
                         case 4:
                        {
                            MenuAPI.SearchManagment();
                            switch (Convert.ToInt32(Console.ReadLine()))
                                {
                                    case 1:
                                    {
                                        ValidationRules.InputID(out var ID);

                                        Console.WriteLine(SearchFunction.SearchStudentByID(ID));
                                        
                                        MenuAPI.Continue(null!);
                                        CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                    case 2:
                                    {
                                        ValidationRules.InputGroupName(out var GroupName);
                                        ValidationRules.InputID(out var ID);

                                        Console.WriteLine(SearchFunction.SearchStudentByGroupName(GroupName, ID));
                                        
                                        MenuAPI.Continue(null!);
                                        CheckForContinue(Convert.ToString(Console.ReadLine()));
                                    } 
                                    break;
                                }
                        }
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MenuAPI.Continue(ex);
                    state = false;
                }
            } while (state);
        }
    }
}
    