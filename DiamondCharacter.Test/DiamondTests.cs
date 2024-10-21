using DiamonCharacter.Domain;

namespace DiamondCharacter.Test
{
    [TestClass]
    public class DiamondTests
    {
        [TestMethod]
        [DataRow('@')]
        [DataRow('N')]
        [DataRow('O')]
        [DataRow('P')]
        [DataRow('Q')]
        [DataRow('R')]
        [DataRow('S')]
        [DataRow('T')]
        [DataRow('U')]
        [DataRow('V')]
        [DataRow('W')]
        [DataRow('X')]
        [DataRow('Y')]
        [DataRow('Z')]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InvalidConstructorArgumentException(char inputCharacter)
        {
            var diamond = new Diamond(inputCharacter);

            Assert.Fail();
        }

        [TestMethod]
        [DataRow('B', 1)]
        [DataRow('C', 2)]
        [DataRow('D', 3)]
        [DataRow('b', 1)]
        [DataRow('c', 2)]
        [DataRow('d', 3)]
        public void MidPoint_scenarios(char inputLetter,
            int expectedMidpoint)
        {
            var diamond = new Diamond(inputLetter);

            Assert.AreEqual(expectedMidpoint, diamond.MidPoint);
        }

        [TestMethod]
        [DataRow('B', 3)]
        [DataRow('C', 5)]
        [DataRow('D', 7)]
        [DataRow('b', 3)]
        [DataRow('c', 5)]
        [DataRow('d', 7)]
        public void NumberOfRows_scenarios(char inputLetter,
            int expectedNumberOfRows)
        {
            var diamond = new Diamond(inputLetter);

            Assert.AreEqual(expectedNumberOfRows, diamond.NumberOfRows);
        }

        [TestMethod]
        [DataRow('B')]
        [DataRow('C')]
        [DataRow('D')]
        [DataRow('b')]
        [DataRow('c')]
        [DataRow('d')]
        public void Validate_NumberOfRows_matches_actual(char inputLetter)
        {
            var diamond = new Diamond(inputLetter);

            Assert.AreEqual(diamond.NumberOfRows, diamond.Rows.Count);
        }

        [TestMethod]
        [DataRow('B')]
        [DataRow('C')]
        [DataRow('D')]
        [DataRow('b')]
        [DataRow('c')]
        [DataRow('d')]
        public void Validate_rows_not_null(char inputLetter)
        {
            var diamond = new Diamond(inputLetter);

            Assert.IsTrue(diamond.Rows != null && diamond.Rows.Count > 0);
        }
    }
}