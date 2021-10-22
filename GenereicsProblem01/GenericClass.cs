using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenereicsProblem01
{
    class GenericClass<T> where T: IComparable                   //Tcomparable is used to identifu the compare to class method
    {
        public T[] value;                                      //array creating
        
        public GenericClass(T[] value)                          
        {
            this.value = value;
        }

        //below method returns the sorted value of the array.
        public T[] Sort(T[] values)                                
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] value)                   //'params is used to make the array dynamic. ie no fixed size needs to be specified beforehand
        {
            var valueSorted = Sort(value);
            return valueSorted[valueSorted.Length - 1];       //returning the last element of the sorted array which is sorted in ascending order
        }

        public void PrintMax()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is :" + max);
        }
    }
}
