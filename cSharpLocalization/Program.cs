using System.Reflection.Metadata;

namespace cSharpLocalization;
class Program
{
    //Main calls all the other functions
    static void Main()
    {
        //string firstName = FirstName_Subroutine(); //Variable is imported from subroutine
        //string lastName = LastName_Subroutine(); //Variable is improted from subroutine
        //Salutations(firstName, lastName); //Function Salutations uses passed parameters to write a greeting to the user
        TemperatureCheck();

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

    //This function asks user for the temperature and then converts it to F or C depending on user input
    static void TemperatureCheck()
    {
        Console.WriteLine("What is the temperature?");
        int temperatureDegree = Convert.ToInt32(Console.ReadLine()); //Use method Convert.ToInt32 to change input type from String to Integer.
        Console.WriteLine("The temperature is " + temperatureDegree + "... Is that in Fahrenheit or Celsius? Write F or C then hit ENTER");
        string temperatureType = Console.ReadLine(); //user writes F or C and inputs variable value

        //if/else statement evaluating if they input F or C
        if (temperatureType == "F")
        {
            Console.WriteLine("Okay. So it is " + temperatureDegree + " degrees Fahrenheit. Big difference from " + temperatureDegree + " degrees Celsius!!!");
        }
        else
        {
            Console.WriteLine("Okay. So it is " + temperatureDegree + " degrees Celsius. Big difference from " + temperatureDegree + " degrees Fahrenheit!!!");
        }
    }
    
    //Function converts the temperature from F to C and 
    static void TemperatureConversion()
    {

    }


}