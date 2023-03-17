using System;

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

            string password = "";

            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();

                int random_upper = random.Next(0, upper.Count);
                password += upper[random_upper];
                upper.RemoveAt(random_upper);

                int random_lower = random.Next(0, lower.Count);
                password += lower[random_lower];
                lower.RemoveAt(random_lower);

                int random_number = random.Next(0, numbers.Count);
                password += numbers[random_number];
                numbers.RemoveAt(random_number);

                int random_special_symbol = random.Next(0, special_symbols.Count);
                password += special_symbols[random_special_symbol];
                special_symbols.RemoveAt(random_special_symbol);
            }

            var password_list = new List<string>();

            for (int i = 0; i < password.Length; i++)
            {
                password_list.Add(password.Substring(i, 1));
            }

            var shuffled_password_list = new List<string>();

            for (int i = 0; i < password.Length; i++)
            {
                Random random = new Random();
                int x = random.Next(0, password_list.Count);
                shuffled_password_list.Add(password_list[x]);
                password_list.RemoveAt(x);
            }

            string shuffled_password = "";

            for (int i = 0; i < shuffled_password_list.Count; i++)
            {
                shuffled_password += shuffled_password_list[i];
            }

            return shuffled_password;
        }

        static void Main()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("PASSWORD NUMBER " + i + " GENERATED: " + generate_password());
            }

            Console.WriteLine("GENERATED 40 PASSWORDS.");
            Console.ReadLine();
        }
    }
}