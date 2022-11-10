using System;
using CourseWork.BLL;


namespace CourseWork.PL {
    public static class Menu
    {
        public static void MainMenu()
        {
            bool state = true;
            int choice = -1;
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
                                    string Name, Surname, YearOfStudy, Speciality;

                                    MenuAPI.InputName(out Name);
                                    MenuAPI.InputSurname(out Surname);
                                    MenuAPI.InputYearOfStudy(out YearOfStudy);
                                    MenuAPI.InputSpeciality(out Speciality);

                                    Functions.AddStudent(Name, Surname, Convert.ToInt32(YearOfStudy), Speciality);
                                    MenuAPI.Continue(null);
                                }
                                    break;
                            }
                        } break;
                    }
                }
                catch

                    (Exception ex)
                {
                    MenuAPI.Continue(ex);
                    state = false;
                }
            } while (state);
        }
    }
}
    