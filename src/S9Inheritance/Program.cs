using S9Inheritance.Models.Demo1;
using S9Inheritance.Models.Demo3;
using S9Inheritance.Models.IEnumerableAndIEnumeratorDemo;
using S9Inheritance.Models.InterfaceDemo2;

namespace S9Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, S9!");
        
        /*
         * Inheritance - First Demo
         * Base Class: Device
         * Child Classes: Radio and TV
         */
        Radio radio = new Radio(false, "Sony");
        radio.SwitchOn();
        radio.ListenRadio();
        radio.SwitchOff();
        radio.ListenRadio();

        TV tv = new TV(false, "Samsung");
        tv.SwitchOn();
        tv.WatchTV();
        tv.SwitchOff();
        tv.WatchTV();
        
        /*
         * Virtual and Override Keywords
         * 
         */
        /*
        Dog dog = new Dog("Sif", 15);
        Console.WriteLine($"{dog.Name} is {dog.Age} years old...");
        dog.Play();
        dog.Eat();
        */
        
        /*
         * Demo 3
         */
        Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
        Console.WriteLine(post1.ToString());
            
        ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Denis Panjuta",
            "https://images.com/shoes", true);

        VideoPost videoPost1 = new VideoPost("FailVideo", "Denis Panjuta",
            "https://video.com/failvideo", true, 10);

        Console.WriteLine(imagePost1.ToString());
        Console.WriteLine(videoPost1.ToString());

        videoPost1.Play();
        Console.WriteLine("Press any key to stop the video!");
        Console.ReadKey();
        videoPost1.Stop();
        Console.ReadLine();
        
        /*
         * Interface Demo 2
         */
        Chair officeChair = new Chair("Brown", "Plastic"); // Assume we also have a class Chair which implements IDestroyable interface
        Chair gamingChair = new Chair("Red", "Wood");
        
        Car damagedCar = new Car(80f, "Blue");
        damagedCar.DestroyablesNearby.Add(officeChair);
        damagedCar.DestroyablesNearby.Add(gamingChair);
        damagedCar.Destroy();
        
        /*
         * Interface Demo 3: IEnumerable and IEnumerator
         *
         * 1. IEnumerable<T> for generic collections
           2. IEnumerable for non-generic collections
           
           IEnumerable<T> contains a single method that you must implement when implementing this interface;
           GetEnumerator(), which returns an IEnumerator<T> object.
           The returned IEnumerator<T> provides the ability to iterate through the collection by exposing a Current
           property that points at the object we are currently at in the collection.
         */
        DogShelter shelter = new DogShelter();
        
        foreach(Dog dog in shelter){ // C# doesn't know how to enumerate DogShelter object
            if(!dog.IsNaughtyDog){
                dog.GiveTreat(2);
            }
            else{
                dog.GiveTreat(1);
            }
        }
        
        // IEnumerable Example
        List<int> numList = new List<int>() {8 , 6, 2};
        int[] numArray = new int[] {1, 7, 1};
        Queue<int> numQueue = new Queue<int> (); // empty queue
        
        Console.WriteLine(CollectionSum(numList));
        Console.WriteLine(CollectionSum(numArray));
        Console.WriteLine(CollectionSum(numQueue));
    }
    
    // IEnumerable Example
    static int CollectionSum(IEnumerable<int> anyCollection)
    {
        int sum = 0;
        foreach(int num in anyCollection)
        {
            sum += num;
        }
        return sum; // Return sum of elements in any collection (iterable)
    }
}