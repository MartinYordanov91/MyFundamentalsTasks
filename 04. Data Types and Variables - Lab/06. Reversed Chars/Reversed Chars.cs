// Create a program that takes 3 lines of characters and prints them in reversed order with a space between them.

char first = char.Parse(Console.ReadLine());
char sekond = char.Parse(Console.ReadLine());
char last = char.Parse(Console.ReadLine());

Console.WriteLine("{2} {1} {0}" ,first, sekond, last);