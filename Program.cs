namespace password_generator
{
    internal class Program
    {
        static string generate_password()
        {
            var upper = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "W", "X", "Y", "Z" };
            var lower = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "w", "x", "y", "z" };
            var numbers = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            var special_symbols = new List<string>() { "!", "@", "#", "$", "%", "&" };
            int password_lenght = 20;
            var password = new List<string>();

            for (int i = 0; i < password_lenght; i++)
            {
                Random random = new Random();

                int x = random.Next(0, 4);
                switch(x)
                {
                    case 0:
                        int random_upper = random.Next(0, upper.Count);
                        password.Add(upper[random_upper]);
                        break;
                    case 1:
                        int random_lower = random.Next(0, lower.Count);
                        password.Add(lower[random_lower]);
                        break;
                    case 2:
                        int random_number = random.Next(0, numbers.Count);
                        password.Add(numbers[random_number]);
                        break;
                    case 3:
                        int random_special_symbol = random.Next(0, special_symbols.Count);
                        password.Add(special_symbols[random_special_symbol]);
                        break;
                }
            }

            return string.Join("", password);
        }

        static void Main()
        {
            int passwords = 40;

            for (int i = 0; i < passwords; i++)
            {
                Console.WriteLine("PASSWORD NUMBER " + i + " GENERATED: " + generate_password());
            }

            Console.WriteLine("GENERATED " + passwords + " PASSWORDS.");
            Console.ReadLine();
        }
    }
}