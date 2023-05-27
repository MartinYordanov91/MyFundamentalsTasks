// Create a program to enter n numbers and calculate and print their exact sum (without rounding).


int nNums = int.Parse(Console.ReadLine());
decimal sum = 0m;

for (int i = 1; i <= nNums; i++)
{
    decimal number = decimal.Parse(Console.ReadLine());
    sum += number;

}
Console.WriteLine($"{sum}");