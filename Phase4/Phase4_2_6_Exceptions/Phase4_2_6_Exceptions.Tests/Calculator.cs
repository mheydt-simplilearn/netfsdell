using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase4_2_6_Exceptions.Tests
{
    public interface ICalculator
    {
        int add(int x, int y);
        int addStrings(string x, string y);
    }


    public class Calculator : ICalculator
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int addStrings(string x, string y)
        {
            if (!Int32.TryParse(x, out var a))
                throw new InvalidOperationException("x param is not a valid integer");

            if (!Int32.TryParse(y, out var b))
                throw new InvalidOperationException("y param is not a valid integer");
                
            return a + b;
        }
    }

}
