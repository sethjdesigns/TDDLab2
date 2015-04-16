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

            public Person(string name, string dateOfBirth, string social)
            {
                this.name = name;
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

            public object canVote()
            {
                throw new NotImplementedException();
            }
    }

}
