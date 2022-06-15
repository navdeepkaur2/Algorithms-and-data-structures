class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        int n = GetNumberInput();
        Console.WriteLine($"Please enter {n} words :");
        string[] words = GetWordsInput(n);
        Console.WriteLine("Please enter a character");
        char Character = GetCharacterInput();
        int counter = GetCounterInput(words, Character);
        int charCounter = CharacterCounter(words);
        int percentage = counter * 100 / charCounter;
        PrintResults(Character, counter, percentage);
    }
    public static void PrintResults(char Character, int counter, double percentage)
    {
        Console.WriteLine($"The letter {Character} appears {counter} times in the array. " +
        $"This letter makes up more than {percentage} of the total number of characters.");
    }
    public static int GetNumberInput()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
    public static string[] GetWordsInput(int n)
    {
        string[] words = new string[n];
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }
        return words;
    }

    public static char GetCharacterInput()
    {
        char Character = Console.ReadKey().KeyChar;
        return Character;
    }
    public static int CharacterCounter(string[] words)
    {
        int characterCounter = 0;
        for (int i = 0; i < words.Length; i++)
        {
            characterCounter += words[i].Length;
        }
        return characterCounter;
    }
    public static int GetCounterInput(string[] words, char Character)
    {
        int counter = 0;
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            for (int j = 0; j < word.Length; j++)
            {
                char character = word[j];
                if (character == Character)
                {
                    counter++;
                }
            }
        }
        int totalChar = words.Aggregate(0, (previous, current) => previous + current.Count());
        return counter;
    }

}


