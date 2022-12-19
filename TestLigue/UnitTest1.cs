using Xunit;
using appWin_liguev2;
using System;

namespace TestLigue
{
    public class UnitTest1 
    {
        Attaquant test1 = new Attaquant();

        

        [Fact]
        public void TestMoyenne()
        {
            Attaquant test1 = new Attaquant();
            test1.NbBut = 10;
            test1.NbMatch = 2;
            double expected = 5;

            double actual = test1.CalculerStats();

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestAjouterBut()
        {
            Attaquant test1 = new Attaquant();
            test1.NbBut = 10;
            
            int expected = 11;

            int actual = test1.AjouterBut();

            Assert.Equal(expected, actual);

        }
    }
}