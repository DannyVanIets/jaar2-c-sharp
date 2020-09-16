using NUnit.Framework;
using Opgave3;
using System.Text;

namespace NUnitTestProject1
{
    public class Tests
    {
        private bool[,] bord;
        [SetUp]
        public void Setup()
        {
            bord = new bool[,]
            {
                { false, false, false, false },
                { false, true, true, false },
                { false, true, true, false },
                { false, false, false, false }
            };
        }

        [TestCase ("1,1", true)]
        [TestCase ("4,4", false)]
        public void Check_CellStatus_ReturnTrueAndFalse(string input, bool result)
        {
            Simulatie simulatie = new Simulatie(bord);

            bool answer = simulatie.CellStatus(input);

            Assert.AreEqual(result, answer);
        }

        [TestCase("0,0", 2)]
        [TestCase("1,1", 3)]
        public void Check_AantalBuren_Return2and3(string input, bool result)
        {
            Simulatie simulatie = new Simulatie(bord);

            int answer = 0;
            answer = simulatie.AantalBuren(input);

            Assert.AreEqual(result, answer);
        }

        public void Print_ToString_ReturnTrue()
        {
            Simulatie simulatie = new Simulatie(bord);

            bool[,] bord2 = new bool[,]
            {
                { false, false, false, false },
                { false, true, true, false },
                { false, true, true, false },
                { false, false, false, false }
            };

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bord2.GetLength(0); i++)
            {
                for (int j = 0; j < bord2.GetLength(1); j++)
                {
                    if (bord2[i, j])
                    {
                        builder.Append("O");
                    }
                    else
                    {
                        builder.Append(".");
                    }
                }
                builder.AppendLine();
            }
            string answer = builder.ToString();

            string result = simulatie.ToString();

            Assert.AreEqual(result, answer);
        }

        public void Check_VolgendeStap_return()
        {

        }
    }
}