namespace S11AdvancedTopics.Topics;

public class WriteFile
{
    public static void FileWriteMain()
    {
        // Method 1
        string[] lines = { "First 250", "Second 242", "Third 240" };

        File.WriteAllLines(@"F:\C# Masterclass Course\Projects\Assets\highscores.txt", lines);
        /*
        // Method 2
        Console.WriteLine("Please give the file a name");
        string fileName = Console.ReadLine();
        Console.WriteLine("Please enter the text for the file");
        string input = Console.ReadLine();
        File.WriteAllText(@"F:\C# Masterclass Course\Projects\Assets\" + fileName + ".txt", input);
        */
        // Method 3
        using(StreamWriter file = new StreamWriter(@"F:\C# Masterclass Course\Projects\Assets\myText2.txt"))
        {
            foreach(string line in lines)
            {
                if (line.Contains("2"))
                {
                    file.WriteLine(line);
                }
            }
        }

        using (StreamWriter file = new StreamWriter(@"F:\C# Masterclass Course\Projects\Assets\myText2.txt", true))
        {
            file.WriteLine("Additional line");
        }

        /*
         * // Example 1 - reading Text
        string text = System.IO.File.ReadAllText(@"F:\C# Masterclass Course\Projects\Assets\textFile.txt");

        Console.WriteLine("Textfile contains following text: {0}", text);

        string[] lines = System.IO.File.ReadAllLines(@"F:\C# Masterclass Course\Projects\Assets\textFile.txt");

        Console.WriteLine("Contents of textfile.txt = ");
        foreach(string line in lines)
        {
            Console.WriteLine("\t" + line);
        }
        */
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}