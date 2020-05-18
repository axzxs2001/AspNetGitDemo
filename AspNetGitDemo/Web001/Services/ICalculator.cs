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

        /// <summary>
        /// 相除
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>a/b的商</returns>
        double Division(double a, double b);

        /// <summary>
        /// 相乘
        /// </summary>
        /// <param name="number1">number1</param>
        /// <param name="number2">number2</param>
        /// <returns>number1*number2的积</returns>
        double Multiply(double number1, double number2);

        /// <summary>
        /// 乘方
        /// </summary>
        /// <param name="number1">number1</param>
        /// <param name="number2">number2</param>
        /// <returns>number1乘方number2</returns>
        double Pow(double number1, double number2);

    }
}
