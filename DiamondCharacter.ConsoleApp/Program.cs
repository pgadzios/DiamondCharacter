using DiamonCharacter.Domain;

namespace DiamondCharacter.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if(args.Length != 1
                || args[0].Length != 1)
            {
                Console.WriteLine($"Please pass in a single letter argument (valid values are 'B-M')");
                return;
            }

            var jeweler = new Jeweler();
            var inputLetter = args[0];

            var command = new MakeDiamondCommand(char.Parse(inputLetter));

            var diamondResult = jeweler.MakeDiamond(command);

            if(diamondResult == null)
            {
                Console.WriteLine("An unexpected error occurred.");

                return;
            }

            if(diamondResult.Diamond != null)
            {
                WriteToConsole(diamondResult);
            }
            else
            {
                Console.WriteLine(diamondResult.ErrorMessage);
            }
        }

        private static void WriteToConsole(MakeDiamondResult result )
        {
            if(result.Diamond == null)
            {
                return;
            }

            foreach (var row in result.Diamond.Rows)
            {
                var text = "";
                foreach (var character in row.Items)
                {
                    text += character.CharacterDisplay;
                }

                Console.WriteLine($"{text}");
            }
        }
    }
}
