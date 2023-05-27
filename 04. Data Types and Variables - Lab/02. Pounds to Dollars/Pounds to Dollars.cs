// Create a program that converts British pounds to US dollars formatted to the 3rd decimal point.
// 1 British Pound = 1.31 Dollars

decimal britishPound =decimal.Parse(Console.ReadLine());
decimal dollars = 1.31m;

dollars *= britishPound;

Console.WriteLine($"{dollars:f3}");