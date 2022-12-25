double Adding(double x,double y)
{
    return x + y;
}

double Subtract (double x,double y)
{
    return x - y;
}

double Multiply (double x, double y)
{
    return x * y;
}

double Divide(double x,double y)
{
    if (y == 0)
        return 0;
    else
    return x / y;
}

Console.WriteLine("Enter x:");
double.TryParse(Console.ReadLine(), out double number1);
Console.WriteLine("Enter y:");
Double.TryParse(Console.ReadLine(), out double number2);
Console.WriteLine("Choose one of them:[+,-,*,/]");
string operation=Console.ReadLine();


switch (operation)
{
    case "+":
        Console.WriteLine("Result:" + Adding(number1, number2));
        break;
    case "-":
        Console.WriteLine("Result:" +Subtract(number1, number2));
        break;
    case "*":
        Console.WriteLine("Result:" + Multiply(number1, number2));
        break; 
    case "/":
        if (Divide(number1, number2) != 0)
          Console.WriteLine("Result:" + Divide(number1, number2));
        else
            Console.WriteLine("Zero division error");
        break;
    default:
        Console.WriteLine("Wrong input");
        break;
}