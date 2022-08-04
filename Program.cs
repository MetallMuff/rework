string[] mass = new string[6] { "8645", "I", "did", "DarkSoul", "it!", "new_line" };
string[] mass2 = new string[mass.Length];
void symbol_count(string[] mass, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            mass2[count] = array1[i];
            count++;
        }
    }
}

