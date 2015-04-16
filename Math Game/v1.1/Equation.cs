using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class Equation
    {  /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
        */
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public int Result { get; set; }
        public char Operator { get; set; }

        public Equation(int operand1, int operand2, char _operator)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            Result = 0;
            Operator = _operator;
        }
    }
}
