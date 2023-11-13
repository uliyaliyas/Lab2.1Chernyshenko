Console.Write("Введите k:");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите l:");
int l = int.Parse(Console.ReadLine());
Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine((n > 1 || m <= l + k) && (!(n > 2) || (Math.Pow(m, 2) > Math.Pow(l, 2))));
