// Задача 1.

System.Console.Write("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

int ind1 = num / 10000;
int ind2 = (num / 1000) % 10;
int ind4 = (num / 10) % 10;
int ind5 = num % 10;
if ( ind1 == ind5 && ind2 == ind4)
{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}




// Задача 2. 

System.Console.Write("Введите х1:");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите х2:");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
System.Console.WriteLine("Расстояние=" + Math.Round(distance,2));




// Задача 3. 

System.Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < num; i++)
{   
    System.Console.WriteLine($"{i+1} {Math.Pow(i+1,3)} \n");
}
