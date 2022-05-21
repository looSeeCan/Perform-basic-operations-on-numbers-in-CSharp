// See https://aka.ms/new-console-template for more information

Console.WriteLine("PERFORM BASIC OPERATIONS ON NUMBERS IN CSHARP\n");

Console.WriteLine("///////////////////////Add two numeric values///////////////////////////////////////////////\n");

int firstNumber  = 12;
int secondNumber = 7;
Console.WriteLine($"{firstNumber + secondNumber}");

Console.WriteLine("//////////////////////////////////////////////////////////");

Console.WriteLine($"\n/////////////////////Mix data types to force implicit type conversions\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\n");

string firstName = "Lucycan Ly";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

Console.WriteLine("/////////////////////////////////////////////////////////////");

Console.WriteLine($"\n///////////////////////////Attemp a more advanced case of adding numbers and concatenating strings//////////////////\n");

Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");//treats as string

Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////\n");

Console.WriteLine($"////////////////Add parentheses to make our intention clear to the compiler////////////////////////\n");

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");//() order of operations operator

Console.WriteLine($"\nMATH OPERATORS");