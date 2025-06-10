using System.Text;

namespace PasswordGenerator
{
    class Program
    {
        static string GeneratePassword()
        {
            var upper = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "W", "X", "Y", "Z" };
            var lower = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "w", "x", "y", "z" };
            var numbers = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            var specialSymbols = new List<string>() { "!", "@", "#", "$", "%", "&" };

            int passwordLength = 20;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < passwordLength; i++)
            {
                Random random = new Random();

                int x = random.Next(0, 4);
                switch(x)
                {
                    case 0:
                        int randomUpper = random.Next(0, upper.Count);
                        sb.Append(upper[randomUpper]);
                        break;
                    case 1:
                        int randomLower = random.Next(0, lower.Count);
                        sb.Append(lower[randomLower]);
                        break;
                    case 2:
                        int randomNumber = random.Next(0, numbers.Count);
                        sb.Append(numbers[randomNumber]);
                        break;
                    case 3:
                        int randomSpecialSymbol = random.Next(0, specialSymbols.Count);
                        sb.Append(specialSymbols[randomSpecialSymbol]);
                        break;
                }
            }

            return sb.ToString();
        }

        static void Main()
        {
            int passwords = 40;

            for (int i = 0; i < passwords; i++)
            {
                Console.WriteLine("PASSWORD NUMBER " + i + " GENERATED: " + GeneratePassword());
            }

            Console.WriteLine("GENERATED " + passwords + " PASSWORDS.");
            Console.ReadLine();
        }
    }
}