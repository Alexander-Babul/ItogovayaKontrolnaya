// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

void Main()
{
int RazmerMassiva = Razmer("Введиье размер массива: ");
string[] SamMassiv = ZapolnenieSamMassiv(RazmerMassiva);
PrintMassiv(SamMassiv);
}

int Razmer(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

string[] ZapolnenieSamMassiv(int VvedenniRazmer)
{
    string[] massiv = new string[VvedenniRazmer];
    for(int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        massiv[i] = Console.ReadLine();
    }
    return massiv;
}

void PrintMassiv(string[] a)
{
    Console.WriteLine("[" + string.Join(",", a) + "]");
}


Main();
