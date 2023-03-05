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
