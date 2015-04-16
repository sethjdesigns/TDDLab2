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

            public Person(string name) 
            {
                this.name = name;
            }

            public string checkName()
            {
                return name;
            }

            public object checkBirthday()
            {
                throw new NotImplementedException();
            }
    }

}
