using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLab2
{

    public class Person 
    {
        private string name;
        private string dateOfBirth;
        private DateTime birthday;
        private string social;
        public int age;
        public string firstName;
        public string lastName;
        public float now;
        public float dob;
        public string[] names;

            public Person(string name, string dateOfBirth, string social)
            {
                this.name = name;
                names = name.Split();
                firstName = names[0];
                lastName = names[1];
                this.dateOfBirth = dateOfBirth;
                birthday = DateTime.Parse(dateOfBirth);
                this.social = social;
                now = float.Parse(DateTime.Now.ToString("yyyy.MMdd"));
                dob = float.Parse(birthday.ToString("yyyy.MMdd"));
                age = (int)(now - dob);
            }

            public string checkName()
            {
                return name;
            }

            public DateTime checkBirthday()
            {
                return birthday;
            }

            public object checkSSN()
            {
                return social;
            }


            public object checkAge()
            {
                return age;
            }

            public bool canVote()
            {
                if ((this.age >= 18) && (this.social.Length == 11))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public object newName()
            {
                this.name = "Seth";
                return name;
            }

            public object formatFirstLast()
            {
                return name;
            }

            public object formatLastFirst()
            {
                var lastFirst = lastName + ", " + firstName;
                return lastFirst;
            }
    }

}
