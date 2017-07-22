using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeString
{
    public class Kata
    {
        public bool PrimeString(string input)
        {
            if (input.Length == 1)
            {
                return true;
            }
            for (var i = 1; i <= input.Length / 2; i++)
            {
                if (input.Length % i != 0) continue;
                var separator = new[] { input.Substring(0, i) };
                if (input.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}