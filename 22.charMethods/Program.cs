namespace _22.charMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char digit = '5';
            char letter = 'A';
            char lowerLetter = 'b';
            char space = ' ';

            // Check if the character is a digit
            Console.WriteLine(char.IsDigit(digit)); // Output: True

            // Check if the character is a letter
            Console.WriteLine(char.IsLetter(letter)); // Output: True

            // Check if the character is a letter or digit
            Console.WriteLine(char.IsLetterOrDigit(lowerLetter)); // Output: True

            // Check if the character is lowercase
            Console.WriteLine(char.IsLower(lowerLetter)); // Output: True

            // Check if the character is uppercase
            Console.WriteLine(char.IsUpper(letter)); // Output: True

            // Check if the character is whitespace
            Console.WriteLine(char.IsWhiteSpace(space)); // Output: True

            // Convert to lowercase
            char lower = char.ToLower(letter);
            Console.WriteLine(lower); // Output: 'a'

            // Convert to uppercase
            char upper = char.ToUpper(lowerLetter);
            Console.WriteLine(upper); // Output: 'B'

            // Parse a string to a char
            char parsedChar = char.Parse("Z");
            Console.WriteLine(parsedChar); // Output: 'Z'

            // Try to parse a string to a char
            if (char.TryParse("X", out char tryParsedChar))
            {
                Console.WriteLine(tryParsedChar); // Output: 'X'
            }

            // IsNumber
            char numberChar = '3';
            Console.WriteLine(char.IsNumber(numberChar)); // Output: True

            // IsPunctuation
            char punctuationChar = '.';
            Console.WriteLine(char.IsPunctuation(punctuationChar)); // Output: True

            // IsSeparator
            char separatorChar = ' ';
            Console.WriteLine(char.IsSeparator(separatorChar)); // Output: True


            // IsSymbol
            char symbolChar = '$';
            Console.WriteLine(char.IsSymbol(symbolChar)); // Output: True

            Console.ReadKey();
        }
    }
}
