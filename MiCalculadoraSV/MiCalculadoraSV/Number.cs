using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadoraSV
{
    public class Number
    {
        /** ATRIBUTOS **/
        private double number;
        /**|||||||||||||||||||||||||||||||||||||||||||||**/
        /** CONSTRUCTOR **/
        public Number()
        {
        }
        public Number(string number)
        {
            if (IsValidNumber(number))
            {
                this.number = Double.Parse(number);
            }
            else
            {
                MessageBox.Show(number + " es inválido.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        
            }
            
        }
        /**|||||||||||||||||||||||||||||||||||||||||||||**/
        /** FUNCIONES PUBLICAS **/
        public string ToDecimal()
        {
            int result = 0;
            char[] digits = number.ToString().ToCharArray();
            Array.Reverse(digits);
            for(int i = 0; i < digits.Length; i++) {
                char digit = digits[i];

                if (digit == '1')
                    result += (int) Math.Pow(2, i);
                else if (digit == '0')
                    continue;
                else
                {
                    MessageBox.Show("Debe colocar un numero binario.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    result = 0;
                    break;
                }

            }
            return result.ToString();
        }
        public string ToBinary()
        {
            int decimalInt = (int) number;
            string result = "";
            if (decimalInt > 0) {
                while (decimalInt > 0) {
                    result = (decimalInt % 2) + result;
                    decimalInt = decimalInt / 2;
                }
            }
            return result;
        }
        public static Number GetResult(Number a, Number b, string op)
        {
            Number result = new Number();
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "x":
                    result = a * b;
                    break;
                default:
                    MessageBox.Show("Elija un operador válido.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

            }
            return result;
        }
        public static bool IsValidNumber(string x)
        {
            return Double.TryParse(x, out double result);
        }
        /**|||||||||||||||||||||||||||||||||||||||||||||**/
        /** SOBRECARGAS DE OPERADORES **/
        public static Number operator +(Number a, Number b)
        {
            return new Number((a.number + b.number).ToString());
        }
        public static Number operator -(Number a, Number b)
        {
            return new Number((a.number - b.number).ToString());
        }
        public static Number operator /(Number a, Number b)
        {
            return new Number((a.number / b.number).ToString());
        }
        public static Number operator *(Number a, Number b)
        {
            return new Number((a.number * b.number).ToString());
        }
        /**|||||||||||||||||||||||||||||||||||||||||||||**/
        /** GETTERS  **/
        public string GetNumber() {
            return number.ToString();
        }
    }
}
