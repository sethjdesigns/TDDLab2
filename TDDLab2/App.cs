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
        public DateTime birthday;

            public Person(string name, string dateOfBirth)
            {
                this.name = name;
                this.dateOfBirth = dateOfBirth;
                birthday = DateTime.Parse(dateOfBirth);
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
                throw new NotImplementedException();
            }
    }

}
