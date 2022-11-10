using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork.BLL
{[Serializable]
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public int Course { get; set; }
        public string NameOfGroup { get; set; }
        
        public Group group;
        public Student(string firstName,string lastName,int course,string id,string nameOfGroup)
        {
            FirstName = firstName;
            LastName = lastName;
            Course = course;
            ID = id;
            NameOfGroup = nameOfGroup;
            group = new Group(Course, NameOfGroup);
        }
        
        public override string ToString()
        {
            return $"Student: {LastName} {FirstName}\n"+
                   $"FirsName: {FirstName}\n"+
                   $"LastName: {LastName}\n"+
                   $"Group: {group}\n"+
                   $"Course: {Course}\n"+
                   $"Student ID: {ID}\n";
        }
    }
}


