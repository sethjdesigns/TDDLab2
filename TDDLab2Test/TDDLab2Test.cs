using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TDDLab2;

namespace TDDLab2Test
{
    public class Test
    {
        //Check to see if we can create a person and add a name
        [Fact]
        public void CreateNewPerson() 
        {
            var person1 = new Person("Brandon", "1990/3/17");
            var checkName = person1.checkName();
            var expected = "Brandon";

            Assert.Equal(expected, checkName);
        }
        
        //Check to see if we can add birthday arg
        [Fact]
        public void GetBirthday()
        {
            var person1 = new Person("Brandon", "1990/3/17");
            var checkBirthday = person1.checkBirthday();
            var expected = new DateTime(1990, 3, 17);

            Assert.Equal(expected, checkBirthday);
        }

        //Check to see if we can add SS# arg
        [Fact]
        public void GetSSN()
        {
            var person1 = new Person("Brandon", "1990/3/17");
            var checkSocial = person1.checkSSN();
            var expected = "123-12-1234";

            Assert.Equal(expected, checkSocial);
        }
    }
}
