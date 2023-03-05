void CreateArraytxt()
{
    StreamWriter f = new StreamWriter("text.txt");
    string str = "0";
    while (str != string.Empty) // Заполняем массив и сохраняем в файл txt.
    {
        Console.Write("Введите значение> ");
        str = Console.ReadLine()!;
        f.WriteLine(str);
    }
    f.Close();
}

string[] CreateShortArray(string[] lines)
{
    int j = 0;
    string[] lineChort = new string[lines.Length];
    for (int i = 0; i < lines.Length; i++)
    {
        if (lines[i].Length <= 3)
        {
            lineChort[j] = lines[i];
            j++;
        }
    }
    return lineChort;
}
