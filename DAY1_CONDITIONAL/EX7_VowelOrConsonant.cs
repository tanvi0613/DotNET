namespace Exe19Dec
{
    public static class VowelOrConsonant
    {
        /// <summary>
        /// Check if a character is a vowel
        /// </summary>
        /// <param name="character">Input character for vowel</param>
        public static void IsVowel(char character)
        {
            character = char.ToLower(character);

            switch (character)
            {
                case 'a':Console.WriteLine("Character is vowel");
                break;
                case 'e':Console.WriteLine("Character is vowel");
                break;
                case 'i':Console.WriteLine("Character is vowel");
                break;
                case 'o':Console.WriteLine("Character is vowel");
                break;
                case 'u':Console.WriteLine("Character is vowel");
                break;
                default:Console.WriteLine("Character is not vowel");
                break;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter character to check for vowel: ");
            char character = Console.ReadLine()!.Trim()[0];
            IsVowel(character);
        }
    }
}
