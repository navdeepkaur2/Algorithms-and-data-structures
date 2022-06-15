class Program
{
    public static void Main()
    {
        string word = "YESTERDAY";
        Console.WriteLine(IsPalindrome(word));
        string word2 = "Programmatic Python";
        Console.WriteLine(DuplicateCharacters(word2));
    }
    public static bool IsPalindrome(string testString)
    {
        while (testString.Length > 1)
        {
            if (testString[0] != testString[testString.Length - 1])
            {
                return false;
            }
            testString = testString.Substring(1, testString.Length - 2);
        }
        return true;
    }
    public static char[] DuplicateCharacters(string testString)
    {
        //firstly,find the character in the array
        //iterate over with for loop
        //find if its repeating itself
        //return an array with that character
        char[] resultArr = null;
        for (int i = 0; i < testString.Length; i++)
        {
            for (int j = 0; j < testString.Length; j++)
            {
                if (testString[i] == testString[j])
                {
                    if (resultArr == null)
                    {
                        resultArr = new char[1] { testString[i] };
                    }
                    else
                    {
                        Array.Resize(ref resultArr, resultArr.Length + 1);
                        resultArr[resultArr.Length - 1] = testString[i];
                    }
                }
            }
        }
        return resultArr;
    }

}
