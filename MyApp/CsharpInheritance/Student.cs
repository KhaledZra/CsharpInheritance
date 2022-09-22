﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    internal class Student : Human
    {
        private string _studentID;

        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }

        public Student(int age, string name, string studentid)
        {
            StudentID = studentid;
            Age = age;
            Name = name;
        }

        public void Present()
        {
            Console.WriteLine("I'm a student!");
        }
    }
}
