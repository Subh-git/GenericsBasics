using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenereicsProblem01
{
    class GenericClass
    {
        public static int MaxNumber(int firstNum, int secondNum, int thirdNum)
        {
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
