namespace DiamonCharacter.Domain
{
    public class MakeDiamondResult
    {
        public Diamond? Diamond { get; private set; }

        public string? ErrorMessage { get; private set; }

        public MakeDiamondResult(string errorMessage)
        {
            this.ErrorMessage = errorMessage;
        }

        public MakeDiamondResult(Diamond diamond)
        {
            this.Diamond = diamond;
        }
    }
}
