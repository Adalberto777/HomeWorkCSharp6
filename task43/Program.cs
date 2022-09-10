//программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("введите число k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите число b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите число k2");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine("введите число b2");
double b2 = double.Parse(Console.ReadLine());
                                                                              
double FaindX(double k1, double b1, double k2, double b2) 
{ 
    double x = (b2 - b1) / (k1 - k2);
    
    return x;
}

double FaindY(double k1, double b1, double k2, double b2) 
{ 
    //double y = k2*FaindX(k1, b1, k2, b2)+b2;
    double y = (k2 * b1 - k1 * b2) / (k1 -k2);
    
    return y;
}

if(k1 == k2 && b1 != b2) Console.WriteLine($"прямые паралельны и не имеют точек пересечения");
if(k1 == k2 && b1 == b2) Console.WriteLine($"прямые совпадают, попробуте ввести разные коэффициенты k или b");
if(k1 != k2) Console.WriteLine($"координаты точки пересечения двух прямых: ({FaindX(k1, b1, k2, b2)};{FaindY(k1, b1, k2, b2)})");
