using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTable
{
    class Checker
    {
        public bool check(String input)
        {
            if (String.Equals(input, ""))
            {
                return false;
            }
            try
            {
                if (int.Parse(input) >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }
        
        public bool isThereInt(String input)
        {
            if (String.Equals(input, ""))
            {
                return false;
            }
            try
            {
                int.Parse(input);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
           
        }
    }
}
