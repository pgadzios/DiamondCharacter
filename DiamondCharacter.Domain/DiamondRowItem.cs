namespace DiamonCharacter.Domain
{
    public class DiamondRowItem
    {
        public int ColumnNumber { get; private set; }

        public string CharacterDisplay { get; private set; }

        public DiamondRowItem(int columnNumber, char character)
        {
            CharacterDisplay = char.ToString(character);
            ColumnNumber = columnNumber;
        }
    }
}
