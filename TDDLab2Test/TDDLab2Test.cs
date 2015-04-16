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
            var person1 = new Person("Brandon", "1990/3/17", "123-12-1234");
            var checkName = person1.checkName();
            var expected = "Brandon";

            Assert.Equal(expected, checkName);
        }
        
        //Check to see if we can add birthday arg
        [Fact]
        public void GetBirthday()
        {
            var person1 = new Person("Brandon", "1990/3/17", "123-12-1234");
            var checkBirthday = person1.checkBirthday();
            var expected = new DateTime(1990, 3, 17);

            Assert.Equal(expected, checkBirthday);
        }

        //Check to see if we can add SS# arg
        [Fact]
        public void GetSSN()
        {
            var person1 = new Person("Brandon", "1990/3/17", "123-12-1234");
            var checkSocial = person1.checkSSN();
            var expected = "123-12-1234";

            Assert.Equal(expected, checkSocial);
        }

        //Compute the person’s age.
        [Fact]
        public void GetAge()
        {
            var person1 = new Person("Brandon", "1990/3/17", "123-12-1234");
            var checkAge = person1.checkAge();
            var expected = 25;

            Assert.Equal(expected, checkAge);
        }

        //Determine if the person can vote in the U.S.
        [Fact]
        public void ValidVoter() 
        {
            var person1 = new Person("Brandon", "1990/3/17", "123-12-1234");
            var checkEligble = person1.canVote();
            var expected = true;

            Assert.Equal(expected, checkEligble);
        }

        //Check if Age prop works
        [Fact]
        public void AgeProp()
        {
            var person1 = new Person("Brandon", "1990/3/17", "123-12-1234");
            var checkAgeProp = person1.age;
            var expected = 25;

            Assert.Equal(expected, checkAgeProp);
        }

        [Fact]
        public void ChangeName()
        {
            var person1 = new Person("Brandon", "1990/3/17", "123-12-1234");
            var newName = person1.newName();
            var expected = "Seth";

            Assert.Equal(expected, newName);


        }
    }
}
