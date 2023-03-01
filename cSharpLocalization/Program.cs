using System.Reflection.Metadata;

namespace cSharpLocalization;
class Program
{
    //Main calls all the other functions
    static void Main()
    {
        InitialGreeting();
        Console.ReadLine();
        string firstName = FirstName_Subroutine(); //Variable is imported from subroutine
        string lastName = LastName_Subroutine(); //Variable is improted from subroutine
        Salutations(firstName, lastName); //Function Salutations uses passed parameters to write a greeting to the user
        TemperatureCheck();
        Goodbye(firstName, lastName);
    }

    static void Goodbye(string first, string last)
    {
        Console.WriteLine("Goodbye " + first + " " + last + ".");
    }

    //Function assigns first name to variable firstName for export to Main
    static string FirstName_Subroutine()
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        while (string.IsNullOrEmpty(firstName) ^ int.TryParse(firstName, out int value)) //While loop that checks to make sure input is not null and not an integer
        {
            Console.WriteLine("Try again! Write your name once more");
            firstName = Console.ReadLine();
        }

        return firstName;
    }

    //Function assigns last name to variable lastName for export to Main
    static string LastName_Subroutine()
    {
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();
        while (string.IsNullOrEmpty(lastName) ^ int.TryParse(lastName, out int value)) //While loop that checks to make sure input is not null and not an integer
        {
            Console.WriteLine("Try again! Write your name once more");
            lastName = Console.ReadLine();
        }
        return lastName;
    }

    //This is the subroutine for greeting the user. It passes two parameters through the function. Paramaters used in main are first and last name of user.
    static void Salutations(string alpha, string beta)
    {
        //Console.WriteLine(localDate.ToString("t"));
        string output = "";
        output = "Hello " + alpha + " " + beta;
        Console.WriteLine(output);
    }

    //This function asks user for the temperature and then converts it to F or C depending on user input. Then offers the user the option to convert it to Celsius. 
    static void TemperatureCheck()
    {
        Console.WriteLine("What is the temperature in Fahrenheit where you're at, right now? Quick! It's urgent!");
        int temperatureDegree = Convert.ToInt32(Console.ReadLine()); //Variable is the temperature in Fahreinheit that user inputs. Use method Convert.ToInt32 to change input type from String to Integer.
        
        //If/else statement with four different responses depending on the temperature the user inputs
        if (temperatureDegree < 36) {
            Console.WriteLine("Wow! " + temperatureDegree + " degrees Fahrernheit! That's freezing!!!");
        } 
            else if (temperatureDegree > 36 && temperatureDegree < 70) { 
            Console.WriteLine("Okay," + temperatureDegree + " degrees Fahrernheit isn't exactly warm. Don't forget a coat!");
        }
            else if (temperatureDegree > 70 && temperatureDegree < 88) {
            Console.WriteLine(temperatureDegree + " degrees Fahrernheit. That's quite warm. Don't forget your sunscreen!");
        } 
            else {
            Console.WriteLine("OMG!!!" + temperatureDegree + " degrees Fahrernheit is way too hot! Stay indoors!!!");
        }
        Console.WriteLine("Hit ENTER for good news.");
        Console.ReadLine();

        //logic for converting temperature to celsius
        Console.WriteLine("Temperatures don't sound as extreme when converted to Celsius. Would you like me to convert the temperature to Celsius? Write Y for YES and N for NO.");
        string answer = Console.ReadLine();
        if (answer == "Y") {
            int temperatureMinus = temperatureDegree - 32; //create this variable first to abide by order of operations in celsius conversion.
            int temperatureCelsius = temperatureMinus * 5 / 9;
            Console.WriteLine(temperatureDegree + " degrees Fahreinheit = " + temperatureCelsius + " degrees Celcius");
        }
        else { 
            Console.WriteLine("I didn't want to do it anyay.");
        }
    }

    static void InitialGreeting()
    {
        string[] greetings = { "Good Morning.", "Good Afternoon.", "Good Evening." };
        string enter = " Hit any key to continue.";
        DateTime localDate = DateTime.Now; //Gets users device's time

        //Determine the index of the appropriate greeting based on the current hour
        int hourIndex = Convert.ToInt32(localDate.ToString("HH")); //hour formatting set to 24 hour with double digits
        if (hourIndex > 5 && hourIndex < 12)
        {
            Console.WriteLine(greetings[0] + enter);
        }
            else if (hourIndex > 12 && hourIndex < 17)
        {
            Console.WriteLine(greetings[1] + enter);
        }
            else
        {
            Console.WriteLine(greetings[2] + enter);
        }
        return; 
    }
}