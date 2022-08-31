using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    internal class Person
    {

        private string firstname;
        private string lastname;
        private int age;

        public string FirstName {
            get
            {
                return firstname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value);
                }
                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value);
                }
                lastname = value;
            }
        }

        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 120 && value < 0)
                {
                    throw new ArgumentNullException("the age input is Wrong");
                }
                age = value;
            }
        }
        
        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }
    }
}
