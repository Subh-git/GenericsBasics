using System;

namespace GenereicsProblem01
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the generic class method by creating different objects
            //we need to create diff objects so that we can use other data types 
            int[] arr = { 125, 265, 235, 145, 120 };
            GenericClass<int> generic = new GenericClass<int>(arr);
            generic.PrintMax();


        }
    }
}
