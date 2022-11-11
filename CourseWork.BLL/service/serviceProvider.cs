

namespace CourseWork.BLL
{
    public static class Services
    {
        #region work with student

        public static void AddStudent(string name, string surname, int course, string ID, string groupName)
        {
            StudentLogic.AddStudent(name, surname, course, ID, groupName);
        }

        public static void DeleteStudent(string ID)
        {
            StudentLogic.DeleteStudent(ID);
        }

        public static void ChangeStudentData(string ID, string newName, string newSurname, int newYearOfStudy,
            string newGroup)
        {
            StudentLogic.ChangeStudentData(ID, newName, newSurname, newYearOfStudy, newGroup);
        }

        public static string GetAllStudents()
        {
            return StudentLogic.GetAllStudents();
        }

        public static string getStudentByID(string ID)
        {
            return StudentLogic.getStudentByID(ID);
        }


        #endregion

        #region work with groups

        public static void AddGroup(string name, int yearOfStudy)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            GroupLogic.AddGroup(yearOfStudy, name);
        }

        public static void DeleteGroup(string name)
        {
            GroupLogic.DeleteGroup(name);
        }

        public static void ChangeGroupData(string name, string newName, int newYearOfStudy)
        {
            GroupLogic.ChangeGroupData(name, newYearOfStudy, newName);
        }

        public static string GetGroupByName(string name)
        {
            return GroupLogic.GetGroupByName(name);
        }

        public static void AddStudentToGroup(string GroupName, string ID)
        {
            GroupLogic.AddStudentToGroup(GroupName, ID);
        }

        public static void RemoveStudentFromGroup(string groupName, string ID)
        {
            GroupLogic.RemoveStudentFromGroup(groupName, ID);
        }


        #endregion

        #region work with hostel

            public static void AddHostel(int numberOfHostel, int numberOfFloor, int numberOfRooms, int limit)
            {
                HostelLogic.AddHostel(numberOfHostel, numberOfFloor, numberOfRooms, limit);
            }

            public static void ChangeHostelData(int numberOfHostel, int newNumber)
            {
                HostelLogic.ChangeHostelData(numberOfHostel, newNumber);
            }

            public static void AddStudentToHostel(int hostelNumber, int roomNumber, string ID)
            {
                HostelLogic.AddStudentToHostel(hostelNumber, roomNumber, ID);
            }

            public static void RemoveStudentFromHostel(int numberOfHostel, int numberOfRoom, string studentName,
                string surname)
            {
                HostelLogic.RemoveStudentFromHostel(numberOfHostel, numberOfRoom, studentName, surname);
            }

            public static string GetInfoByNumber(int numberOfHostel)
            {
                return HostelLogic.GetInfoByNumber(numberOfHostel);
            }


        #endregion

    }
}

