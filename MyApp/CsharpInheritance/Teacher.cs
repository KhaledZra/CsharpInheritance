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

        public new void Speak()
        {
            Console.WriteLine("I'm a teacher!");
        }

        public override void Introduction()
        {
            base.Introduction();
            Console.WriteLine($"I'm also a teacher and my ID is: {TeacherID}");
        }
    }
}
