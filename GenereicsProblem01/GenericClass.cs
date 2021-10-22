using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenereicsProblem01
{
    class GenericClass
    {
        public static double MaxNumber(double firstNum, double secondNum, double thirdNum)
        {
            //comparision of three double/float numbers
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
    }
}
