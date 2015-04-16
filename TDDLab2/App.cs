using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLab2
{

    public class Person : IComparable<Person>
    {
        public string name;
        public string dateOfBirth;
        public DateTime birthday;
        public string social;
        public int age;
        public string firstName;
        public string lastName;
        public float now;
        public float dob;
        public string[] names;

            public Person(string name, string dateOfBirth, string social)
            {
                this.name = name;
                this.dateOfBirth = dateOfBirth;
                this.social = social;

                names = name.Split();
                firstName = names[0];
                lastName = names[1];

                birthday = DateTime.Parse(dateOfBirth);
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

            public int CompareTo(Person other)
            {
                // Alphabetic sort if birthday is equal. [A to Z]
                if (this.birthday == other.birthday)
                {
                    return this.lastName.CompareTo(other.lastName);
                }

                // Default to lastname sort. [High to low]
                return this.lastName.CompareTo(other.lastName);
            }


    }
}
