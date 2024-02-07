char[,] charArray = new char[,]
{
    { 'H', 'e', 'l', 'l', 'o' },
    { 'W', 'o', 'r', 'l', 'd' }
};

string str = "";
int rows = charArray.GetLength(0);
int cols = charArray.GetLength(1);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        str += charArray[i, j];
    }
}

Console.WriteLine(str);