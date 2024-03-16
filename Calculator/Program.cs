// First draft

// Declare variables and then initialize to zero
//double num1 = 0; double num2 = 0;

// Display title as the C# console calculator app.
//Console.WriteLine("Console Calculator in C#\r");
//Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
//Console.WriteLine("! If you use a decimal, please write a coma ',', and not a dot '.' ! Type a number, and then press Enter");
//num1 = Convert.ToDouble(Console.ReadLine());

// Ask the user to type the second number.
//Console.WriteLine("! If you use a decimal, please write a coma ',', and not a dot '.' ! Type a number, and then press Enter");
//num2 = Convert.ToDouble(Console.ReadLine());

// Ask the user to choose an option.
//Console.WriteLine("Choose an option from the following list");
//Console.WriteLine("\ta - Add");
//Console.WriteLine("\ts - Substract");
//Console.WriteLine("\tm - Multiply");
//Console.WriteLine("\td - Divide");
//Console.WriteLine("Your option? ");

// Use a switch statement to do the math.
//switch (Console.ReadLine())
//{
//    case "a":
//        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
//        break;
//    case "b":
//        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
//        break;
//    case "c":
//        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
/**        break;
    case "d":
        while (num2 == 0)
        {
            Console.WriteLine("Enter a non-zero divider: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}
// Wait for the user to respond before closing.
Console.WriteLine("Press any key to close the calculator console app...");
Console.ReadKey();
*/

class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN;
        switch(op) 
        {
            case "a":
                result = num1 + num2 ;
                break;
            case "b":
                result = num1 - num2 ;
                break;
            case "c":
                result = num1 * num2 ;
                break;
            case "d":
                if (num2 != 0)
                {
                    result = num1 / num2 ;
                }
                break;
            default:
                break;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console calculator in C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            Console.Write("Type a number, then press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not a valid input. Please enter an integer value: ");
                numInput1 = Console.ReadLine();
            }

            Console.Write("Type another number, then press inter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not a valid input. Please enter an integer value: ");
                numInput2 = Console.ReadLine();
            }
            Console.WriteLine("Choose an operator from the following list: ");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Substract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("Your option ? ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error. \n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occured trying to do the math.\n - Details :" + e.Message);
            }
            Console.WriteLine("------------------------\n");

            Console.Write("Press 'n' and Enter to close the app, or press any other key an enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");

        }
        return;
    }
}



