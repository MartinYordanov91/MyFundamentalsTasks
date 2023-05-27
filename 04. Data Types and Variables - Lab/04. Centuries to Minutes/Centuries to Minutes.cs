// Create a program to enter an integer number of centuries and convert it to years, days, hours and minutes.

int num = int.Parse(Console.ReadLine());
int years = num * 100;
decimal days = years * 365.2422m;
days = (int)days;
int hours = (int)days * 24;
int minutes = hours * 60;


Console.WriteLine($"{num} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
