using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FromClassLibrary
    {
        public string IntToString(int a)
        {
            string ret = "";
            switch(a)
            {
                case 0:
                    ret = "Zero";
                    break;
                case 1:
                    ret = "One";
                    break;
                case 5:
                    ret = "Five";
                    break;
                default:
                    throw new Exception("Unhandled case!");
            }
            return ret;
        }
    }
}
