// You will be given an integer that will be a distance in meters. Create a program that converts meters to
// kilometers formatted to the second decimal point.


int meeters = int.Parse(Console.ReadLine());
decimal kilometers;

kilometers = meeters/ 1000.0m;

Console.WriteLine($"{kilometers:f2}");