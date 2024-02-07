Console.WriteLine("Введите строку:");
string input = Console.ReadLine();

if (IsPalindrome(input))
{
    Console.WriteLine("Введенная строка является палиндромом.");
}
else
{
    Console.WriteLine("Введенная строка не является палиндромом.");
}

static bool IsPalindrome(string input)
{
    string normalized = input.Replace(" ", "").ToLower();

    for (int i = 0; i < normalized.Length / 2; i++)
    {
        if (normalized[i] != normalized[normalized.Length - 1 - i])
        {
            return false;
        }
    }

    return true;
}