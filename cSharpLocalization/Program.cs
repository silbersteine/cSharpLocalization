using System.Globalization;
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
        
        //ISO code selected by user is stored in ISO variable and used to change UI and formatting cultures
        string ISO = langSelector();
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(ISO);
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(ISO);
        getDateTime();

        //
        TemperatureCheck();
        Goodbye(firstName, lastName);
    }

    static void Goodbye(string first, string last)
    {
        Console.WriteLine(lang.goodbye, first, last);
    }

    //Function assigns first name to variable firstName for export to Main
    static string FirstName_Subroutine()
    {
        Console.WriteLine(lang.firstName);
        string firstName = Console.ReadLine();
        while (string.IsNullOrEmpty(firstName) ^ int.TryParse(firstName, out int value)) //While loop that checks to make sure input is not null and not an integer
        {
            Console.WriteLine(lang.nameError);
            firstName = Console.ReadLine();
        }

        return firstName;
    }

    //Function assigns last name to variable lastName for export to Main
    static string LastName_Subroutine()
    {
        Console.WriteLine(lang.lastName);
        string lastName = Console.ReadLine();
        while (string.IsNullOrEmpty(lastName) ^ int.TryParse(lastName, out int value)) //While loop that checks to make sure input is not null and not an integer
        {
            Console.WriteLine(lang.nameError);
            lastName = Console.ReadLine();
        }
        return lastName;
    }

    //This is the subroutine for greeting the user. It passes two parameters through the function. Paramaters used in main are first and last name of user.
    static void Salutations(string first, string last)
    {
        //Console.WriteLine(localDate.ToString("t"));
        Console.WriteLine(lang.greeting, first, last);
    }

    //This function asks user for the temperature and then converts it to F or C depending on user input. Then offers the user the option to convert it to Celsius. 
    static void TemperatureCheck()
    {
        Console.WriteLine("What is the temperature in Fahrenheit where you're at, right now? Quick! It's urgent!");
        int temperatureDegree = Convert.ToInt32(Console.ReadLine()); //Variable is the temperature in Fahreinheit that user inputs. Use method Convert.ToInt32 to change input type from String to Integer.
        
        //If/else statement with four different responses depending on the temperature the user inputs
        if (temperatureDegree < 36) {
            Console.WriteLine(lang.coldTemp, temperatureDegree);
        } 
            else if (temperatureDegree > 36 && temperatureDegree < 70) { 
            Console.WriteLine(lang.coolTemp, temperatureDegree);
        }
            else if (temperatureDegree > 70 && temperatureDegree < 88) {
            Console.WriteLine(lang.warmTemp, temperatureDegree);
        } 
            else {
            Console.WriteLine(lang.hotTemp, temperatureDegree);
        }
        Console.WriteLine(lang.tempNews);
        Console.ReadLine();

        //logic for converting temperature to celsius
        Console.WriteLine(lang.tempConv);
        string answer = Console.ReadLine();
        if (answer == "Y") {
            int temperatureMinus = temperatureDegree - 32; //create this variable first to abide by order of operations in celsius conversion.
            int temperatureCelsius = temperatureMinus * 5 / 9;
            Console.WriteLine(lang.tempConvResults, temperatureDegree, temperatureCelsius);
        }
        else { 
            Console.WriteLine(lang.reject);
        }
    }

    static void InitialGreeting()
    {
        //Removed concatenation to create three distinct strings for improved localizability then externalized them to resx. file
        //string greetingMorning = "Good Morning. Hit any key to continue";
        //string greetingAfternoon = "Good afternoon. Hit any key to continue";
        //string greetingEvening = "Good evening. Hit any key to continue";

        DateTime localDate = DateTime.Now; //Gets users device's time

        //Determine the index of the appropriate greeting based on the current hour
        int hourIndex = Convert.ToInt32(localDate.ToString("HH")); //hour formatting set to 24 hour with double digits
        if (hourIndex > 5 && hourIndex < 12)
        {
            Console.WriteLine(lang.greetMorning);
        }
            else if (hourIndex > 12 && hourIndex < 17)
        {
            Console.WriteLine(lang.greetAfternoon);
        }
            else
        {
            Console.WriteLine(lang.greetEvening);
        }
        return; 
    }
    static string langSelector()
    {
        Console.WriteLine(lang.isoPrompt);
        string response = Console.ReadLine();
        while (response != "es-ES" && response != "fr-FR" && response != "de-DE" && response != "en-US" && response != "")
        {
            if (response == "")
            {
                Console.WriteLine(lang.isoError0);
                response = Console.ReadLine();
            }
            else
            {
                Console.WriteLine(lang.isoError1);
                response = Console.ReadLine();
            }
        }
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(response);
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(response);
            Console.WriteLine(lang.isoSuccess, response); //Excellente!
            return response;
    }

    static void getDateTime()
    {
        DateTime localDate = DateTime.Now;
        Console.WriteLine(localDate.ToString("f", CultureInfo.CurrentCulture));
    }
}