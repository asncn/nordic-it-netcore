using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class SimpleNumbersValidator 
    {
         public bool Check(IEnumerable <int> numbers)
        {
            foreach (int n in numbers)
            {

                for (int i = 2; i < (n - 1); i++)
                    if (n % i == 0)
                        return false;

            }
            return true;
        }
    }
}
