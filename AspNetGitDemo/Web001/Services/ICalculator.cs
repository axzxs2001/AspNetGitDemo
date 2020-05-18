using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web001.Services
{
    public interface ICalculator
    {
        /// <summary>
        /// 相加
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>a+b的和</returns>
     
        double Plus(double a, double b);
        /// <summary>
        /// 相减
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>a-b的差</returns>
        double Subtraction(double a, double b);

    }
}
