Console.WriteLine("Введите аргументы уравнения первой прямой");
Console.Write("K1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите аргументы уравнения второй прямой");
Console.Write("K2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2){
    if (b1 == b2){
        Console.WriteLine("Прямые совпадают");
        return 0;
    }
    else {
        Console.WriteLine("Прямые не пересекаются");
        return 0;
    }
}
else {
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения : ({x}; {y})");
    return 0;
}