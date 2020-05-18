using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web001.Services
{
    public class Calculator : ICalculator
    {
        /// <summary>
        /// 相加
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>a+b的和</returns>
        public double Plus(double a, double b)
        {
            return a + b;
        }
    }
}
