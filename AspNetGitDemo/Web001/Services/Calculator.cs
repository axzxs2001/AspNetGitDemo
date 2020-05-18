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
        /// <param name="number1">number1</param>
        /// <param name="number2">number2</param>
        /// <returns>number1+number2的和</returns>
        public double Plus(double number1, double number2)
        {
            return number1 + number2;
        }

        /// <summary>
        /// 相减
        /// </summary>
        /// <param name="number1">number1</param>
        /// <param name="number2">number2</param>
        /// <returns>number1-number2的差</returns>
        public double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }

        /// <summary>
        /// 相除
        /// </summary>
        /// <param name="number1">number1</param>
        /// <param name="number2">number2</param>
        /// <returns>number1/number2的商</returns>
        public double Division(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
