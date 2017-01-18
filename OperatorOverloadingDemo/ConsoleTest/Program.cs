using System;
using OperatorOverloading;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vec1 = new GeometricVector(2, 2, 4, 4); 
            Console.WriteLine(vec1.GetVectorCordinate());           // the output is:  2, 2 
            var vec2 = new GeometricVector(3, 3, 6, 6);
            Console.WriteLine(vec2.GetVectorCordinate());           // the output is: 3, 3
            var vec3 = new GeometricVector(new Point2D(2, 2));
            Console.WriteLine($"vec1 + vec2 {vec1 + vec2}");          // the output is: 5, 5 
            Console.WriteLine(vec1.Equals(vec2));                   // the output is: false
            Console.WriteLine(vec1==vec2);                         // the output is: false   
            Console.WriteLine(vec1==vec3);                        // the output is: true    
            Console.WriteLine(vec3.GetVectorLength());           // the output is: 2,82842712474619
            Console.ReadKey();

        }
    }
}
