using System;
using System.Globalization;
using System.Text;

namespace Timus1014.ProductOfDigits {

    public class Program {

        public static void Main(string[] args) {
            NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            int n = int.Parse(Console.In.ReadLine(), nfi);

            if (n.ToString().Length == 1) {
                Console.WriteLine(n);
            }
            else {
                var results = new List<StringBuilder, int>();
                bool wasDivided = false;
                if (n.ToString().Length != 1) {
                    for (int i = 2; i < 10; i++) {
                        if (n % i == 0)
                            wasDivided = true;
                    }
                }
                else {
                    if(!wasDivided)
                        Console.WriteLine("-1");
                    else
                        Console.WriteLine(n);
                }
            }
        }

        public static StringBuilder Insert(StringBuilder sb, char value) {
            for (int i = 0; i < sb.Length; i++) {
                if (sb[i] > value)
                    return sb.Insert(i, value);
            }
            return sb.Append(value);
        }

        
    }

    public class Result {

    }
}