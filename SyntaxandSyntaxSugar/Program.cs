using System;

namespace SyntaxandSyntaxSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            //var answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //response = answer + " is less than nine";
            //}
            //else
            //{
            //response = answer + " is greater than or equal to nine";
            //}

           //inferred typing
            var answer = 4;
              //ternary                              //string interpolation 
            var response = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than or equal to 9";
        }
    }
}

