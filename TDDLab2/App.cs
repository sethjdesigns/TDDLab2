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

            public Person(string name, string dateOfBirth, string social)
            {
                this.name = name;
                var names = name.Split(' ');
                string firstName = names[0];
                string lastName = names[1];
                this.dateOfBirth = dateOfBirth;
                birthday = DateTime.Parse(dateOfBirth);
                this.social = social;
                var now = float.Parse(DateTime.Now.ToString("yyyy.MMdd"));
                var dob = float.Parse(birthday.ToString("yyyy.MMdd"));
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
                var now = float.Parse(DateTime.Now.ToString("yyyy.MMdd"));
                var dob = float.Parse(birthday.ToString("yyyy.MMdd"));
                var age = (int)(now - dob);
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
                throw new NotImplementedException();
            }
    }

}
