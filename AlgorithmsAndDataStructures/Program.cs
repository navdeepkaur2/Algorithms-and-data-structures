Console.WriteLine("Please enter a number:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Please enter {n} words :");
string[] words = new string[n];
for (int i = 0; i < n; i++)
{
    words[i] = Console.ReadLine();
}
Console.WriteLine("Please enter a character");
char Character = Console.ReadKey().KeyChar;
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
double percentage = (totalChar / words.Length) * 100;
Console.WriteLine($"The letter {Character} appears {counter} times in the array. " +
   $"This letter makes up more than {percentage} of the total number of characters.");