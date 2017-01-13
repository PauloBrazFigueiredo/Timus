using System;
using System.Collections.Generic;
using System.Globalization;

namespace Timus1086.Cryptography {

    public class Program {

        public static void Main(string[] args) {
            NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            int n = int.Parse(Console.In.ReadLine(), nfi);
            var primes = new List<int>();
            primes.Add(2);
            for (int i = 0; i < n; i++) {
                int c = int.Parse(Console.In.ReadLine(), nfi);
                Console.WriteLine(GetThPrime(primes, c));
            }
        }

        public static bool IsPrime(int n) {
            for (int i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static int GetThPrime(List<int> primes, int thPrime) {
            while (primes.Count < thPrime) {
                int lastPrime = primes[primes.Count - 1];
                while (!IsPrime(++lastPrime)) {
                }
                primes.Add(lastPrime);
            }
            return primes[thPrime - 1];
        }
    }
}