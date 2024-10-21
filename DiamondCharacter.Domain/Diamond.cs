using System.Diagnostics.Metrics;
using System.Net;

namespace DiamonCharacter.Domain
{
    public class Diamond
    {
        public const int MaxMidPoint = 0;

        private const int LowerCaseToUpperCaseAsciiDrop = 32;
        private const char BaseAsciiLetter = 'A';

        public int MidPoint { get; private set; }

        public int NumberOfRows { get;private set; }

        private List<DiamondRow> _rows;

        public Diamond(char midpointLetter)
        {
            _rows = new List<DiamondRow>();

            var letter = SanitiseToUpperCase(midpointLetter);

            // Validate the input letter is within the allowed range of a diamond B-M
            if (letter == 'A' || letter > 'M')
            {
                throw new ArgumentOutOfRangeException(nameof(midpointLetter));
            }

            Initialise(letter);
        }

        public List<DiamondRow> Rows
        {
            get
            {
                return _rows;
            }
        }

        private void Initialise(char letter)
        {
            MidPoint = (letter - BaseAsciiLetter);
            NumberOfRows = (MidPoint * 2) + 1;

            Dictionary<int, Dictionary<int, char>> rowsOfCharacters = new Dictionary<int, Dictionary<int, char>>();

            var currentLetter = BaseAsciiLetter;

            for (int currentRow = 0; currentRow < NumberOfRows; currentRow++)
            {
                rowsOfCharacters[currentRow] = new Dictionary<int, char>();

                var charactersInRow = rowsOfCharacters[currentRow];

                if (currentRow == 0)
                {
                    // do nothing
                }
                else
                {
                    if (currentRow <= MidPoint)
                    {
                        currentLetter = (char)(currentLetter + 1);
                    }
                    else
                    {
                        currentLetter = (char)(currentLetter - 1);
                    }
                }

                var offset = (BaseAsciiLetter + MidPoint) - currentLetter;
                var offsetLeft = offset;
                var offsetRight = (MidPoint - offset) + MidPoint;

                charactersInRow[offsetLeft] = currentLetter;
                charactersInRow[offsetRight] = currentLetter;
            }

            PopulateRows(rowsOfCharacters);
        }

        private void PopulateRows(Dictionary<int, Dictionary<int, char>> rowsOfCharacters)
        {
            foreach (var rowOfCharacters in rowsOfCharacters)
            {
                var row = new DiamondRow(rowOfCharacters.Key);

                for (int characterInRow = 0; characterInRow < NumberOfRows; characterInRow++)
                {
                    if (rowOfCharacters.Value.ContainsKey(characterInRow))
                    {
                        // Add an item representing the character
                        var rowItem = new DiamondRowItem(characterInRow, rowOfCharacters.Value[characterInRow]);
                        row.AddItem(rowItem);
                    }
                    else
                    {
                        // Add an item to represent an empty space
                        var rowItem = new DiamondRowItem(characterInRow, ' ');
                        row.AddItem(rowItem);
                    }
                }

                _rows.Add(row);
            }
        }

        private static char SanitiseToUpperCase(char value)
        {
            if (IsLowerCaseLetter(value))
            {
                return (char)(value - LowerCaseToUpperCaseAsciiDrop);
            }

            return value;

        }

        private static bool IsLowerCaseLetter(char value)
        {
            return value >= 97 && value <= 122;
        }
    }
}
