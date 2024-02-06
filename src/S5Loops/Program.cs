namespace S5Loops;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, S5!");
        /*
         * For Loops
         */
        int counter = 1;
        for(counter = 1; counter < 20; counter += 2)
        {
            Console.WriteLine(counter);
        }
        
        // foreach loop
        List<int> fibNumbers = [0, 1, 1, 2, 3, 5, 8, 13];
        foreach (int element in fibNumbers)
        {
            Console.Write($"{element} ");
        }
        
        /*
         * Do-While Loop
         */
        int lenghtOfText = 0;
        string wholeText = "";
        do
        {
            Console.WriteLine("Please enter the name of a friend");
            string nameOfAFriend = Console.ReadLine();
            int currentLength = nameOfAFriend.Length;
            lenghtOfText += currentLength;
            wholeText += nameOfAFriend;
        } while (lenghtOfText < 20);
        Console.WriteLine("Thanks, that was enough! " + wholeText);
        
        /*
         * While Loops
         */
        counter = 0;
        string enteredText = "";
        while(enteredText.Equals(""))
        {
            Console.WriteLine("Please press enter to increase amount by one and anything else" +
                              " + enter if you want to finish counting");
            enteredText = Console.ReadLine();
                
            counter++;
            Console.WriteLine("Current people count is {0}", counter);

        }
        Console.WriteLine("{0} people are inside the bus. Press enter to close the program", counter);
        
        /*
         * Break - Continue
         */
        for(counter = 0; counter< 10; counter++)
        {
                
            if(counter %2 ==0)
            {
                Console.WriteLine("Now comes an odd number!");
                continue;
            }
            Console.WriteLine(counter);
        }
        for(counter = 0; counter< 10; counter++)
        {
                
            if(counter %2 ==0)
            {
                Console.WriteLine("Now comes an odd number!");
                break;
            }
            Console.WriteLine(counter);
        }
    }
}