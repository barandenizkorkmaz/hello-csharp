using S12EventsAndDelegates.Examples._2CustomDelegates;

namespace S12EventsAndDelegates.Examples._4LambdaExpressions;

public class LambdaExpressions
{
    
    public delegate bool FilterDelegate(Person p);
    
    public static void LambdaExpressionsMain()
    {
        Person p1 = new Person() {Name = "Aiden", Age = 41};
        Person p2 = new Person() {Name = "Sif", Age = 61};
        Person p3 = new Person() {Name = "Walter", Age = 12};
        Person p4 = new Person() {Name = "Anatoli", Age = 25};
        List<Person> people = new List<Person> {p1, p2, p3, p4};
        
        // Lambda Expressions
        
        /*
         // Expression Lambda (One Line of Statement)
           (input-parameters) => expression;
           
           // Statement Lambda
           (input-parameters) => {
               
           };
         */
        
        // Statement Lambda
        string searchKeyword = "A";
        DisplayPeople("Age > 20 with search keyword " + searchKeyword, people, (p) =>
        {
            return p.Age > 20 && p.Name.ToLower().Contains("a");
        });
        
        // Expression Lambda
        DisplayPeople("Age > 20 with search keyword " + searchKeyword, people, p => p.Age > 20 && p.Name.ToLower().Contains("a"));
    }
    
    static void DisplayPeople(string title, List<Person> people, FilterDelegate filter){
        Console.WriteLine(title);
        foreach(Person p in people){
            if(filter(p)){
                Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
            }
        }
    }
}