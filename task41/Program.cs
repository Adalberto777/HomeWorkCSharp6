// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("введите числа через пробел");
string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); //считывает строку, когда видит пробел отделяет выражение и записывает в массив строк
                                                                              
int CounterPozitiveNumber(string[] st1) 
{ 
    int count = 0;
    foreach (string var in st1)
    {
        if(int.Parse(var) > 0)
        {
            count += 1;
        }
    }
    return count; 
}

Console.WriteLine($"чисел > 0: {CounterPozitiveNumber(st)}");


//int.Parse(st[0])