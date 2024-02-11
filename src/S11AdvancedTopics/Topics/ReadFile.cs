namespace S11AdvancedTopics.Topics;

public class ReadFile
{
    public static void ReadFileMain()
    {
        //Reading Tect from a File
        //exchange the adress of the file with the one you want to use
        string text = System.IO.File.ReadAllText(@"D:\C# Masterclass Course\Projects\Assets\textfile.txt");

        Console.WriteLine("Textfile contains the following text: {0}", text);

        //Receive the Text line by line.
        string[] lines = System.IO.File.ReadAllLines(@"D:\C# Masterclass Course\Projects\Assets\textfile.txt");

        Console.WriteLine("Content of the file line by line:");
        foreach(string line in lines)
        {
            //\t is a tab
            Console.WriteLine("\t" + line);
        }
    }
}