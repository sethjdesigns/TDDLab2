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
            var person1 = new Person("Brandon");
            var checkName = person1.checkName();
            var expected = "Brandon";

            Assert.Equal(expected, checkName);
        }
        
    }
}
