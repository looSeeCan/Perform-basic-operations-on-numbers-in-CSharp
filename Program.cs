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

    Console.WriteLine($"\n/////////////////Attemp a more advanced case of adding numbers and concatenating strings//////////////////\n");

        Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");//treats as string

    Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////\n");

    Console.WriteLine($"////////////////Add parentheses to make our intention clear to the compiler////////////////////////\n");

        Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");//() order of operations operator

    Console.WriteLine($"\n////////////////////MATH OPERATORS//////////////////////////////////////////\n");

        int sum = 7 + 5;
        int difference = 7 - 5;
        int product = 7 * 5;
        int quotient = 7 / 5;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("difference: " + difference);
        Console.WriteLine("product: " + product);
        Console.WriteLine("quotient: " + quotient);// 7/5 = 1.4, but the values after the decimals are truncated, since quotient is defined as an int

        decimal decimalQuotient = 7.0m / 5;//To see division working properly, we need to usse a data type that suppoorts fractional digits afte the decimal point. like decimal.
        Console.WriteLine("\nDecimal quotient: " + decimalQuotient);//in order for this to work, the quotient (left of the assignment operator) must be of type decimal and either the divident or divisor must be of type decimal or both.

        Console.WriteLine("\nWhat if you were working with literal values. In other words, what if you need to divide two variables of type int, but do not what the result truncated.");
        
        int first = 7;
        int second = 5;
        decimal quotient1 = (decimal)first / (decimal)second;//perform a data type cast from int to decimal
        Console.WriteLine("\n" + quotient1);

        Console.WriteLine($"\nModulus of 200 / 5: " + (200 % 5));//when the modulus is 0, that means hte dividend is divisible by the divisor
        Console.WriteLine($"\nModulus of 7 / 5: " + (200 % 7));

        Console.WriteLine("\nOrder of operations");
            //I understand order of operations
    Console.WriteLine("\n///////////////////////////////////////////////////////////////////");
    
    Console.WriteLine($"\n//////////////Increment and Decrement Values///////////////////////////////////");

        int value = 0;
        
        value = value + 5;//these two are the same 
        value += 5;
        Console.WriteLine(value);
        // Console.WriteLine(value + 5);
        // Console.WriteLine(value += 5);
        // Console.WriteLine((value + 5) + (value += 5));
        // Console.WriteLine("\n");

        value = value + 1;//these two are the same 
        Console.WriteLine(value);
        value ++;
        Console.WriteLine(value);
        value = value - 1;
        value -= 1;
        Console.WriteLine(value);
        Console.WriteLine(value++);//
        Console.WriteLine(value);//there is a diffenence in the order of operations here
        Console.WriteLine(value++);//

    Console.WriteLine("\n/////////////////////////////////////////////////////////////////");

    Console.WriteLine("\n////////////////////CHALLENGE////////////////////////\n");

        int fahrenheit = 94;

        decimal convertToCelsius = (fahrenheit - 32) * (5/9m);
        Console.WriteLine($"The temperature is {convertToCelsius} Celsius.");

    Console.WriteLine("\n////////////////////////////////////////////////////");
        