namespace S10Polymorphism.DemoAbstractClasses;

public class AbstractClassesDemo
{
    public static void AbstractClassesDemoMain()
    {
        // Demo: Abstract Classes
        
        // You cannot instantiate abstract classes.
        // Shape shape1 = new Shape(); // ERROR

        var shapes = new List<Shape>()
        {
            new Cube(4),
            new Sphere(4)
        };

        foreach (Shape shape in shapes)
        {
            shape.GetInfo();
            
            /*
             * as and is Keywords
             */
            
            Cube iceCube = shape as Cube;
            
            /*
             * The as operator explicitly converts the result of an expression to a given reference or nullable value type.
             * If the conversion isn't possible, the as operator returns null. Unlike a cast expression, the as operator never throws an exception.
               
               The expression of the form
                              
               '''C#
               E as T
               '''
               
               where E is an expression that returns a value and T is the name of a type or a type parameter, produces the same result as
               
               '''C#
               E is T ? (T)(E) : (T)null
               '''
               
             */
            if (iceCube == null)
            {
                Console.WriteLine("This shape is not a cube...");
            }

            if (shape is Cube) // Type checking using `is` keyword.
            {
                Console.WriteLine("This shape is a cube...");
            }
            
        }
        
        // Cast an object to a cube
        object cube1 = new Cube(7);
        // At this point check the functions available for cube1 by compiler (e.g. Equals, GetType, GetHashCode, ToString) 
        Cube cube2 = (Cube)cube1;
        // Check available functions again. Now, you should see Cube class members.
        
    }
}