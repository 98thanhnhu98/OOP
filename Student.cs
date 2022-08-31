using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OPP
{
    internal class Student
    {
        private int age;
        private string name;
        public int Age 
        { 
            get 
            {
                return age; 
            } 
            set 
            { 
                age = value;
            } 
        }
        public string Name 
        { 
            get 
            {
                return name; 
            } 
            set 
            {
                bool valid = false;
                Regex reg = new Regex("^[a-zA-Z]+$");
                if (reg.Match(value).Success)
                {
                    name = value;
                }
                else
                {
                    throw new InvalidPersonNameException("Your name :" + name + " is not valid");
                }
            }
        }
        public Student(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public override string ToString()
        {
            return "Name :"+ name +" age: "+age;
        }
    }
}
