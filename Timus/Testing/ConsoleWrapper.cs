using System;
using System.IO;

namespace Testing {

    public class ConsoleWrapper : IConsoleWrapper {
        public void SetIn(TextReader newIn) {
            Console.SetIn(newIn);
        }

        public void SetOut(TextWriter newOut) {
            Console.SetOut(newOut);
        }
    }
}