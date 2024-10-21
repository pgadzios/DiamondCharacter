namespace DiamonCharacter.Domain
{
    public class Jeweler
    {
        public MakeDiamondResult MakeDiamond(MakeDiamondCommand makeDiamondCommand)
        {
            if (!makeDiamondCommand.InputLetter.HasValue)
            {
                return new MakeDiamondResult("Please specify an input letter B-M");
            }

            try
            {
                var diamond = new Diamond(makeDiamondCommand.InputLetter.Value);

                return new MakeDiamondResult(diamond);
            }
            catch (ArgumentOutOfRangeException)
            {
                return new MakeDiamondResult("Please specify an input letter B-M");
            }
        }
    }
}
