string input = "HeLLo WoRLD";
string output = "";

for (int i = 0; i < input.Length; i++)
{
    if (char.IsUpper(input[i]))
    {
        output += char.ToLower(input[i]);
    }
    else
    {
        output += input[i];
    }
}

Console.WriteLine(output);