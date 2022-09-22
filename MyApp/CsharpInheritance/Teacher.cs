using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    internal class Teacher : Human
    {
        private string _teacherID;
        public string TeacherID
        {
            get
            {
                return this._teacherID;
            }
            set
            {
                this._teacherID = value;
            }
        }

        public Teacher(int age, string name, string teacherID)
        {
            TeacherID = teacherID;
            Age = age;
            Name = name;
        }

        public void Present()
        {
            Console.WriteLine("I'm a teacher!");
        }
    }
}
