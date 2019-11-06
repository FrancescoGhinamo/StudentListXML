using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace StudentListXML.Students.Backend.Beam
{
    public class Student
    {
        public string Id
        {
            get;
        }

        public string Surname
        {
            get;
        }

        public string  Name
        {
            get;
        }

        public Student(string id, string surname, string name)
        {
            this.Id = id;
            this.Surname = surname;
            this.Name = name;
        }
        
    }
}
