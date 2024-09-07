// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

void Main()
{
int RazmerMassiva = Razmer("Введиье размер массива: ");
string[] SamMassiv = ZapolnenieSamMassiv(RazmerMassiva);
PrintMassiv(SamMassiv);
int NachaloDiapazonaVivoda = 0;
int KonecDiapazonaVivoda = RazmerMassiva - 1;
int KolvoElementovVivoda = 3;
PrintBeforeThreeElementMassiv(SamMassiv, NachaloDiapazonaVivoda, KonecDiapazonaVivoda, KolvoElementovVivoda);
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

void PrintBeforeThreeElementMassiv(string[] a, int ot, int doo, int count)
{
    
    Random Element = new Random();
    string[] randomElements = new string[count];
    for(int i = 0; i < count; i++)
    {
        int randomIndex = Element.Next(ot, doo);
        randomElements[i] = "\"" + a[randomIndex] + "\"";
    }
    Console.Write("[" + string.Join(",", randomElements) + "]");
}

Main();
