namespace S7Collections.Collections;

public class MultiDimensionalArrays
{
    public static void MultiDimensionalArraysMain()
    {
        // 2D Array
        string[,] matrix;
        
        // 3D Array
        int[,,] threeD;
        
        //Declare and initualize a 2-dimensional Array
        int[,] array2D = new int[,]
        {
            {11, 12, 13 },
            {21, 22, 23 },
            {31, 32, 33 }
        };

        //We access the Value 23
        //Note, that Indexes start with 0
        Console.WriteLine(array2D[1, 2]);


        //3-Dimensions are more complex, but the Conzept is the same
        string[,,] array3D = new string[,,] 
        {
            {
                {"000", "001", "002" },
                {"010", "011", "012" },
                {"020", "021", "022" }
            },
            {
                {"100", "101", "102" },
                {"110", "111", "112" },
                {"120", "121", "122" }
            },
            {
                {"200", "201", "202" },
                {"210", "211", "212" },
                {"220", "221", "222" }
            },
            {
                {"Hi", "I", "am" },
                {"also", "part", "of" },
                {"the", "3-dimensional", "array" }
            }

        };

        //We access the Value "201"
        Console.WriteLine(array3D[2, 0, 1]);

        //Hi
        Console.WriteLine(array3D[3, 0, 0]);

        //Will give us the Dimension of the corresponding Array
        int amountDimensions = array3D.Rank;
        Console.WriteLine("The Dimension is {0}", amountDimensions);

        //Multi-dimensional Arrays can also be created that way:
        string[,] arr2D = { { "00", "01" } };

        Console.WriteLine(arr2D[0, 0]);
        
        /*
         * Nested For Loops
         */
        foreach (int item in array2D)
        {
            Console.Write(item + " ");
            Console.WriteLine("Printing next item");
        }

        Console.WriteLine($"The number of rows in 2D Array: {array2D.GetLength(0)}");
        Console.WriteLine($"The number of columns in 2D Array: {array2D.GetLength(1)}");

        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Console.Write($"At ({i},{j}) is {array2D[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}