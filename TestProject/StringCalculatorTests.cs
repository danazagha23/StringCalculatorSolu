using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_Test()
        {
            //Arrange 
            int expected = 5;

            //Act
            var numbers = new StringCalculatorService();
            int actual = numbers.Add("2,3");

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
