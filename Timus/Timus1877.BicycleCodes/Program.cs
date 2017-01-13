using System;
using System.Globalization;

namespace Timus1877.BicycleCodes {

    public class Program {

        public static void Main(string[] args) {
            NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            int first = int.Parse(Console.In.ReadLine(), nfi);
            int second = int.Parse(Console.In.ReadLine(), nfi);

            if (first % 2 == 0 || second % 2 != 0)
                Console.WriteLine("yes");
            else if (first % 2 != 0 || second % 2 == 0)
                Console.WriteLine("no");
        }
    }
}