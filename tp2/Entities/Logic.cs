using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Logic
    {
        public static void ThrowDivideByZero(string number)
        {
            try
            {
                int result = int.Parse(number) / 0;
            }
            catch 
            {
                throw;
            }
        }
        public static float Divide(string divider, string dividend)
        {
            try
            {
                return float.Parse(divider) / int.Parse(dividend);
            }
            catch
            {
                throw;
            }
        }
        public static void ValidateInputs(string divide, string dividend)
        {          
            if (!(int.TryParse(divide, out int x) && int.TryParse(dividend, out int y)))
                throw new InvalidInputException("Seguro ingreso una letra o no ingreso nada!");  
        }
        public static void ValidateInputs(string number)
        {
            if (!(int.TryParse(number, out int result)))
                throw new InvalidInputException("Seguro ingreso una letra o no ingreso nada!");
        }
        public static void ThrowException()
        {
            throw new ArithmeticException();
        }
        public static void ThrowCustomException()
        {
            throw new CustomException("Exception personalizada!");
        }
    }
}
