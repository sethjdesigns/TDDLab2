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

            public Person(string name, string dateOfBirth, string social)
            {
                this.name = name;
                this.dateOfBirth = dateOfBirth;
                birthday = DateTime.Parse(dateOfBirth);
                this.social = social;
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
    }

}
