using System.Diagnostics;

namespace StartingCSharp;

class Program
{
    static void Main(string[] args)
    {
        EnterAName();

        DifferenceBetweenprinting();

        AddingTwoNumbers();

        SayHi("Kinga", 21);

        double CubeNumber = Cube();
        Console.WriteLine($"The cube of the given number is {CubeNumber}");

        IfStatement();

        MaxOfTwoNumbers();

        WordGuessing();

        CreatingClasses();
        
        PractisingConstructorMethods();

        PractisingGetSet();

        StaticAttributes();

        StaticMethods();

        Inheritance();
    }

    static void EnterAName()
    {
        Console.WriteLine("------------- EnterAName method --------------");
        Console.Write("Enter a name: ");
        string your_name = Console.ReadLine()!;
        Console.WriteLine("Hello " + your_name);
    }

    static void DifferenceBetweenprinting()
    {
        Console.WriteLine("------------- DifferenceBetweenprinting method --------------");
        string name = "Kinga";
        var date = DateTime.Now;

        // Composite formatting:
        Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
        // String interpolation:
        Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
        Console.WriteLine((decimal)51 / 2);
        int num = 6;
        num *= 2;
        Console.WriteLine(Math.Pow((double)num, 5.0));
    }
    static void AddingTwoNumbers()
    {
        Console.WriteLine("------------- AddingTwoNumbers method --------------");
        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter another number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The sum of {num1} and {num2} is {num1+num2}");
    }
    static void SayHi(string name, int age)
    {
        Console.WriteLine("------------- SayHi method --------------");
        Console.WriteLine("Hello " + name + " you are " + age);
    }
    static double Cube()
    {
        Console.WriteLine("------------- Cube method --------------");
        Console.Write("Number: ");
        double number = Convert.ToDouble(Console.ReadLine());
        double result = number * number * number;
        return result; 
    }
    static void IfStatement()
    {
        Console.WriteLine("------------- IfStatement method --------------");
        bool IsMale = false;
        bool IsTall = false;

        if (IsMale && IsTall)
        {
            Console.WriteLine("You are a tall male");

        }
        else if (IsTall && !IsMale )
        {
            Console.WriteLine("You are a tall woman");
        }
        else if(IsMale && !IsTall)
        {
            Console.WriteLine("You are short male");
        }
        else
        {
            Console.WriteLine("You are a short woman");
        }
    }
    static void MaxOfTwoNumbers()
    {
        Console.WriteLine("------------- MaxOfTwoNumbers method --------------");
        Console.Write("Give me a number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Give me another number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        if (number1 > number2)
        {
            Console.WriteLine($"{number1} is greater than {number2}");
        }
        else
        {
            Console.WriteLine($"{number2} is greater than {number1}");
        }
    }    
    static void WordGuessing()
    {
        Console.WriteLine("------------- WordGuessing method --------------");
        string word = "lion";
        string guessing = "";
        int YourGuess = 0;
        int GuessLimit = 3;
        while (word != guessing && YourGuess < GuessLimit)
        {
            Console.Write("Enter a word: ");
            guessing = Console.ReadLine()!;
            YourGuess++;
            if (word == guessing)
            {
                Console.WriteLine("You won");
                break;
            }
            else if ( GuessLimit == YourGuess )
            {
                Console.WriteLine("You lost");
                break;
            }
        }
    }

    public static void CreatingClasses()
    {
        Console.WriteLine("------------- CreatingClasses method --------------");
        Book book1 = new Book();
        book1.title = "HP";
        book1.author = "JK Rowling";
        book1.pages = 400;
        Console.WriteLine(book1.title);

    }
    static void PractisingConstructorMethods()
    {
        Console.WriteLine("------------- PractisingConstructorMethods method --------------");
        Student student1 = new ("Jim", "Business", 2.4);
        Student student2 = new ("Pam", "Art", 3.6);

        Console.WriteLine($"Has {student1.name} Honors? {student1.HasHonors()}");
        Console.WriteLine($"Has {student2.name} Honors? {student2.HasHonors()}");

    }
    static void PractisingGetSet()
    {
        Console.WriteLine("------------- PractisingConstructorMethods method --------------");
        Movie movie1 = new Movie("Avengers", "Somebody", "G");
        Movie movie2 = new Movie("Lord of the Rings", "Idontknow", "R");

        Console.WriteLine(movie1.title);
    }
    static void StaticAttributes()
    {
        Console.WriteLine("------------- StaticAttributes --------------");
        Song holiday = new Song("Holiday", "Greenday", 200);
        Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
        Console.WriteLine(Song.SongCount + " (This is a static attribute, this belongs to the class itself)");
        Console.WriteLine($"{holiday.title} {kashmir.title} (These are the titles of the holiday and kashmir variable I created)");
    }
    static void StaticMethods()
    {
        Console.WriteLine("------------- StaticMethods --------------");
        Console.WriteLine($"The square root of 144 is {Math.Sqrt(144)}");
        UsefulTools.SayHi(" Mike");
    }
    static void Inheritance()
    {
        Console.WriteLine("------------- Inheritance --------------");
        Chef chef = new();
        chef.MakeChicken();
        ItalianChef itchef = new();
        itchef.MakePasta();
        chef.MakeSpecialDisch();
        itchef.MakeSpecialDisch();
    }
}