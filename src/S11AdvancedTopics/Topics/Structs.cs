namespace S11AdvancedTopics.Topics;

public class Structs
{
    public struct Game // Structs cannot inherit but can implement interfaces
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine("Game 1's name is :{0}", name);
            Console.WriteLine("Game 1' was developed by :{0}", developer);
            Console.WriteLine("Game 1's rating is :{0}", rating);
            Console.WriteLine("Game 1 was released in :{0}", releaseDate);
        }
    }

    public static void StructsMain()
    {
        Game game1;

        game1.name = "Pokemon Go";
        game1.developer = "Niantic";
        game1.rating = 3.5;
        game1.releaseDate = "01.07.2016";

        game1.Display();
        
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}