namespace using_the_Caesar_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку для шифрования: ");
            string input = Console.ReadLine();

            Console.Write("Введите сдвиг: ");
            int shift = int.Parse(Console.ReadLine());

            string encrypted = Encrypt(input, shift);
            Console.WriteLine("Зашифрованная строка: " + encrypted);

            // для дешифрования можно использовать тот же сдвиг с отрицательным знаком
            string decrypted = Encrypt(encrypted, -shift);
            Console.WriteLine("Расшифрованная строка: " + decrypted);

            Console.ReadLine();
        }

        static string Encrypt(string input, int shift)
        {
            string result = "";

            // приведение сдвига к диапазону от 1 до 25
            shift = shift % 26;
            if (shift < 0)
                shift += 26;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = (char)((((c - 'a') + shift) % 26) + 'a');
                    result += encryptedChar;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
