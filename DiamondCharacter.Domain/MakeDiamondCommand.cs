namespace DiamonCharacter.Domain
{
    public class MakeDiamondCommand
    {
        public char? InputLetter { get; private set; }

        public MakeDiamondCommand(char inputLetter)
        {
            InputLetter = inputLetter;
        }
    }
}
