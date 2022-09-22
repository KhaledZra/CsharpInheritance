using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    internal class Human
    {
        private int _age;
        private string _name;

        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public Human()
        {
            Age = 0;
            Name = "Default";
        }

        public Human(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public void Speak()
        {
            Console.WriteLine("I'm a human!");
        }

        public virtual void Introduction()
        {
            Console.WriteLine($"My name is {Name} and i'm {Age} old!");
        }
    }
}
