// A number is special when its sum of digits is 5, 7 or 11.
// Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is
// special or not (True / False)

int number = int.Parse(Console.ReadLine());
int digit = 0;

for (int i = 1; i <= number; i++)
{
    int copie = i;
    int sum = 0;

    while (copie > 0)
    {
        digit = copie % 10;
        sum += digit;
        copie /= 10;
    }

    if (sum  == 5 || sum == 7 || sum == 11 )
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}

