CreateMenu();

void CreateMenu()
{
    try
    {
        //construct menu
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Add Numbers");
        Console.WriteLine("3. Calculate Area");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option: ");

        //accept choice
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SayHello();
                break;
            case "2":
                AddNumbers();
                break;
            case "3":
                CalculateArea();
                break;
            case "4":
                Console.WriteLine("Bye bye <3");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
    }
}

static void SayHello()
{
    Console.WriteLine("Hello, World!");

    ////return to menu
    //Console.WriteLine("Press any key to return to the menu...");
    //Console.ReadKey();
    //CreateMenu();
}

static void AddNumbers()
{
    Console.Write("Enter the first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber + secondNumber;
    Console.WriteLine($"The result is: {result}");

    ////return to menu
    //Console.WriteLine("Press any key to return to the menu...");
    //Console.ReadKey();
    //CreateMenu();
}

static void CalculateArea()
{
    try {
        Console.Write("Enter the length: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        double area = ActuallyCalculateArea(length, width);
        Console.WriteLine($"The area is: {area}");
    } catch (Exception ex) { 
        Console.WriteLine($"Error: {ex.Message}"); 
    }
}

static double ActuallyCalculateArea(double length, double width)
{
    double area = length * width;
    return area;
}
