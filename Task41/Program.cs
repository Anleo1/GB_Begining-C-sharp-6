Console.WriteLine("Введите числа (чтобы закончить ввод, нажмите пробел и enter): ");
int count = 0;
string num_st = "";
while (num_st != " ") {
    num_st = Console.ReadLine();
    if (num_st == " "){
        break;
    }
    if (Convert.ToDouble(num_st) > 0) count++;
} 
Console.WriteLine($"Количество чисел больших нуля = {count}");

