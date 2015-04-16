using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLab2
{

    public class Person 
    {
        private string p;
        private string name;

            public Person(string p) 
            {
                this.p = p;
            }

            public string addName()
            {
                this.name = p;
                return p;
            }
    }

}
