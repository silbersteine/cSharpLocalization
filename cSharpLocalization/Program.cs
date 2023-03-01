using System.Reflection.Metadata;

namespace cSharpLocalization;
class Program
{
    //Main calls all the other functions
    static void Main()
    {
        string firstName = FirstName_Subroutine(); //Variable is imported from subroutine
        string lastName = LastName_Subroutine(); //Variable is improted from subroutine
        Salutations(firstName, lastName); //Function Salutations uses passed parameters to write a greeting to the user
        //TemperatureCheck();

    }

    //Function assigns first name to variable firstName for export to Main
    static string FirstName_Subroutine()
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        return firstName;
    }

    //Function assigns last name to variable lastName for export to Main
    static string LastName_Subroutine()
    {
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();
        return lastName;
    }

    //This is the subroutine for greeting the user. It passes two parameters through the function. Paramaters used in main are first and last name of user.
    static void Salutations(string alpha, string beta)
    {
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
    
    //Function converts the temperature from F to C and 
    static void TemperatureConversion()
    {

    }


}