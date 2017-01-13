using System;
using System.Globalization;
using System.Text;

namespace Timus1149.SinusDances {

    public class Program {

        public static void Main(string[] arg) {
            NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            int n = int.Parse(Console.In.ReadLine(), nfi);

            StringBuilder result = new StringBuilder();
            result.Append('(', n - 1);
            int na = 1;
            while (n >= 1) {
                if (na != 1)
                    result.Append(')');
                result.Append(A(na));
                result.Append('+');
                result.Append(n);
                na += 1;
                n -= 1;
            }

            Console.WriteLine(result.ToString());
        }

        public static string A(int n) {
            StringBuilder result = new StringBuilder(n.ToString());
            result.Append(')', n);
            int a = n - 1;
            while (a >= 1) {
                result.Insert(0, "sin(");
                result.Insert(0, a % 2 == 0 ? "+" : "-");
                result.Insert(0, a.ToString());
                a -= 1;
            }
            result.Insert(0, "sin(");
            return result.ToString();
        }
    }
}