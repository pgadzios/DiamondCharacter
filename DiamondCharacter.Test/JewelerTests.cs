using DiamonCharacter.Domain;

namespace DiamondCharacter.Test
{
    [TestClass]
    public class JewelerTests
    {
        [TestMethod]
        [DataRow('n')]
        [DataRow('o')]
        [DataRow('p')]
        [DataRow('q')]
        [DataRow('r')]
        [DataRow('s')]
        [DataRow('t')]
        [DataRow('u')]
        [DataRow('v')]
        [DataRow('w')]
        [DataRow('x')]
        [DataRow('y')]
        [DataRow('z')]
        public void MakeDiamond_returns_no_diamond_scenarios(char inputLetter)
        {
            var command = new MakeDiamondCommand(inputLetter);

            var jeweler = new Jeweler();

            var result = jeweler.MakeDiamond(command);

            Assert.IsNull(result.Diamond);
        }

        [TestMethod]
        [DataRow('a')]
        [DataRow('b')]
        [DataRow('m')]

        public void MakeDiamond_returns_diamond(char inputLetter)
        {
            var command = new MakeDiamondCommand(inputLetter);

            var jeweler = new Jeweler();

            var result = jeweler.MakeDiamond(command);

            Assert.IsNotNull(result.Diamond);
        }

    }
}