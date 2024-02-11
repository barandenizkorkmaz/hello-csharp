namespace S12EventsAndDelegates.Examples._2CustomDelegates;

public class CustomDelegates
{
    public delegate bool FilterDelegate(Person p);
    
    public static void CustomDelegatesMain()
    {
        Person p1 = new Person() {Name = "Aiden", Age = 41};
        Person p2 = new Person() {Name = "Sif", Age = 61};
        Person p3 = new Person() {Name = "Walter", Age = 12};
        Person p4 = new Person() {Name = "Anatoli", Age = 25};
        List<Person> people = new List<Person> {p1, p2, p3, p4};
        
        DisplayPeople("Kids", people, IsMinor);
        DisplayPeople("Adults", people, IsAdult);
        DisplayPeople("Seniors", people, IsSenior);
    }
    
    static void DisplayPeople(string title, List<Person> people, FilterDelegate filter){
        Console.WriteLine(title);
        foreach(Person p in people){
            if(filter(p)){
                Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
            }
        }
    }
                     
    // FILTERS
    static bool IsMinor(Person p){
        return p.Age < 18;
    }
    static bool IsAdult(Person p){
        return p.Age > 18;
    }
    static bool IsSenior(Person p){
        return p.Age > 65;
    }
}