namespace S4MakingDecisions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, S4!");
        
        // TryParse Mathod
        string str1 = "128";
        int parsedInt;
        bool isSuccess = int.TryParse(str1, out parsedInt);
        // The returned boolean value is true when parsing was successful
        // Recall that int is alias for Int32
        if (isSuccess)
        {
            Console.WriteLine($"Parsing successful. Number is {parsedInt}");
        }
        else
        {
            Console.WriteLine("Parsing failed.");
        }
        
        // It can also be used with float class
        float parsedFloat;
        isSuccess = float.TryParse(str1, out parsedFloat);
        if (isSuccess)
        {
            Console.WriteLine($"Parsing successful. Number is {parsedFloat}");
        }
        else
        {
            Console.WriteLine("Parsing failed.");
        }
        
        /*
         * Switch Statements
         */
        int age = 19;

        switch (age)
        {
            case 15:
                Console.WriteLine("Too young to party in the club!");
                break;
            case 25:
                Console.WriteLine("Good to go!");
                break;
            default:
                Console.WriteLine("How old are you then?");
                break;
        }

        if(age == 15)
        {
            Console.WriteLine("Too young to party in the club!");
        }else if(age == 25)
        {
            Console.WriteLine("Good to go!");
        }
        else
        {
            Console.WriteLine("How old are you then?");
        }

        string username = "Frank";

        switch (username)
        {
            case "Denis":
                Console.WriteLine("username is Denis");
                break;
            case "root":
                Console.WriteLine("username is root");
                break;
            default:
                Console.WriteLine("username is unknown");
                break;
        }
        
        /*
         * Enhanced If Statements: Ternary Operator
         */
        
        //[condition] ? [first expression] : [second expression]
        //condition has to be either true or false

        //The conditional Operator is right-associative
        //That means, that a ? b : c ? d : e
        // is evaluated as a ? b : (c ? d : e)

        //The conditional Operator cannot be overloaded.

        //in celsius
        //Play around with that Value
        int temperature = -5;

        //Our result
        string stateOfMatter;
            
        //Is the Temperature below 0 Degree Celsius?
        if(temperature < 0)
        {
            stateOfMatter = "solid";
        }
        //Is the Temperature higher than 100 Degree Celcius?
        else if(temperature > 100)
        {
            stateOfMatter = "gas";
        }
        //In all other Cases it must be liquid.
        else
        {
            stateOfMatter = "liquid";
        }

        Console.WriteLine("State of Matter is {0}", stateOfMatter);

        //The same result can be achieved by this
        //The enhanced Version of the If-Else-Statement from above
        stateOfMatter = temperature < 0 ? "solid" : (temperature > 100 ? "gas" : "liquid");

        Console.WriteLine("State of Matter is {0}", stateOfMatter);
        


    }
}