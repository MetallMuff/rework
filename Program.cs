string[] mass = new string[6] { "8645", "I", "did", "DarkSoul", "it!", "new_line" };
string[] mass2 = new string[mass.Length];
void symbol_count(string[] mass, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            mass2[count] = mass[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}

symbol_count(mass, mass2);

Console.WriteLine("Полученные данные: ");
Console.Write("~ ");
PrintArray(mass2); 
Console.Write("~ ");

