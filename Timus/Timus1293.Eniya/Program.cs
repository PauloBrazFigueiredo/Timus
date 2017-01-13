using System;
using System.Globalization;

namespace Timus1293.Eniya {

    public class Program {

        public static void Main(string[] args) {
            NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            var line = Console.In.ReadLine().Split(new char[] { ' ' });
            int n = int.Parse(line[0], nfi);
            int a = int.Parse(line[1], nfi);
            int b = int.Parse(line[2], nfi);

            Console.WriteLine(n * 2 * a * b);
        }
    }
}