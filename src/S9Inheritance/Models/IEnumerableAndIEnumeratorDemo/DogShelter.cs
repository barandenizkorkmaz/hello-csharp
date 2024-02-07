using System.Collections;

namespace S9Inheritance.Models.IEnumerableAndIEnumeratorDemo;

public class DogShelter : IEnumerable<Dog> // Implement IEnumerable<T> interface (generic)
{
    public List<Dog> dogs;
        
    public DogShelter(){
        dogs = new List<Dog>() {
            new Dog("Casper", false),
            new Dog("Sif", true),
            new Dog("Oreo", false),
            new Dog("Pixel", false)
        };
    }
        
    IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator() // Generic enumerator
    {
        return dogs.GetEnumerator(); // Use the enumerator (iterable) object of List class
    }
        
    IEnumerator IEnumerable.GetEnumerator() // Non-generic enumerator
    {
        throw new NotImplementedException();
    }
}