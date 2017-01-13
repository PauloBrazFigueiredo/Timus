using System;
using System.Globalization;

namespace Timus2066.SimpleExpression {

    public class Program {

        public static void Main(string[] args) {
            NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            int a = int.Parse(Console.In.ReadLine(), nfi);
            int b = int.Parse(Console.In.ReadLine(), nfi);
            int c = int.Parse(Console.In.ReadLine(), nfi);

            int result;
            
            if(b * c > b + c)
                result = a - b * c;
            else
                result = a - (b + c);

            Console.WriteLine(result);
        }
    }
}