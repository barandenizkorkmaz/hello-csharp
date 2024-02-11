using S12EventsAndDelegates.Examples._2CustomDelegates;

namespace S12EventsAndDelegates.Examples._3AnonymousMethods;

public class AnonymousMethods
{
    public delegate bool FilterDelegate(Person p);
    
    public static void AnonymousMethodsMain()
    {
        Person p1 = new Person() {Name = "Aiden", Age = 41};
        Person p2 = new Person() {Name = "Sif", Age = 61};
        Person p3 = new Person() {Name = "Walter", Age = 12};
        Person p4 = new Person() {Name = "Anatoli", Age = 25};
        List<Person> people = new List<Person> {p1, p2, p3, p4};
        
        // Continues the previous example
        /*
         * Here we created a new variable called filter of type FilterDelegate
         * then we assigned it to an anonymous method instead of an already defined method
         */
        FilterDelegate filter = delegate (Person p){
            return p.Age >= 20 && p.Age <= 30;  
        };
        /*
         * don't forget `;` in the end because we are declaring a variable
         */
        DisplayPeople("After Anonymous Filter", people, filter);

        // or directly declare it upon calling the method DisplayPeople as in the following example
        DisplayPeople("After Anonymous Filter", people, delegate (Person p) {return p.Age >= 20 && p.Age <= 30;});
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