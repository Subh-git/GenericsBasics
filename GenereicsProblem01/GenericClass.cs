using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenereicsProblem01
{
    class GenericClass<T> where T: IComparable                   //Tcomparable is used to identifu the compare to class method
    {
        private T firstNum, secondNum, thirdNum;                //declaring instance variables

        public GenericClass(T firstNum, T secondNum, T thirdNum)       //declaring the class consstructor
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            this.thirdNum = thirdNum;
        }
        public static T MaxOf(T firstNum, T secondNum,T thirdNum)              //declaring the max of method. statci so that we can use it without creating an objecct in this class
        {
            //comparision of three values

            if ((firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0) || (firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(thirdNum) > 0) ||
                    (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) >= 0))
            {
                return firstNum;

            }
            else if ((secondNum.CompareTo(firstNum)>0 && secondNum.CompareTo(thirdNum)>0) || (secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(thirdNum) > 0) ||
                (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) >= 0))
            {
                return secondNum;
            }
            else
            {
                return thirdNum;
            }          
        }

        public T MaxValue()                        //another method that applies the constructor and thenpronts or returns the value
        {
            T max = GenericClass<T>.MaxOf(this.firstNum, this.secondNum, this.thirdNum);
            return max;
        }
    }
}
