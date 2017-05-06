using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    
    enum EnNumericButtons
    {
        btn0 = 0,
        btn1 = 1,
        btn2 = 2,
        btn3 = 3,
        btn4 = 4,
        btn5 = 5,
        btn6 = 6,
        btn7 = 7,
        btn8 = 8,
        btn9 = 9,
    }

    enum EnMathematicalFunctions
    {
        sum = 0,
        substract = 1,
        multiplication = 2,
        division = 3,
        squareRoot = 4,
        percent = 5,
        square = 6,
        Pi = 7,
        Ln = 8,
        cos = 9,
        CTG = 10,
        equals = 11,
    }

    enum Brackets
    {
        roundBracket = 0,
        squareBracket = 1,
        curlyBracket = 2,
    }
}
