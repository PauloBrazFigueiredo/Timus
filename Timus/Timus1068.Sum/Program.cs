using System;
using System.Globalization;

namespace Timus1068.Sum {

    public class Program {

        public static void Main(string[] args) {
            NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            int n = int.Parse(Console.In.ReadLine(), nfi);
            int step = n < 1 ? 1 : -1;
            int sum = 0;

            while (n != 1) {
                sum += n;
                n += step;
            }
            sum += 1;

            Console.WriteLine(sum);
        }
    }
}