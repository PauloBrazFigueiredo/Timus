using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Testing {

    public class ConsoleSimulator {
        private IConsoleWrapper ConsoleWrapper { get; set; }

        public ConsoleSimulator(IConsoleWrapper consoleWrapper) {
            if (consoleWrapper == null)
                throw new ArgumentNullException();
            this.ConsoleWrapper = consoleWrapper;
        }

        private void InitializeStandardIn(List<string> input) {
            StringBuilder inputString = new StringBuilder();
            foreach (var inputLine in input) {
                inputString.AppendLine(inputLine);
            }

            StringReader standardIn = new StringReader(inputString.ToString());
            this.ConsoleWrapper.SetIn(standardIn);
        }

        private StringWriter InitializeStandardOut() {
            var standardOut = new StringWriter();
            this.ConsoleWrapper.SetOut(standardOut);

            return standardOut;
        }

        public RunResult Run(List<string> input, Action<string[]> method, string[] methodArgs) {
            InitializeStandardIn(input);
            var standardOut = InitializeStandardOut();

            method(methodArgs);
            var results = standardOut.ToString().Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            return new RunResult(results);
        }

        public RunResult Run(List<string> input, Action<string[]> method) {
            return Run(input, method, new string[0] {});
        }
    }
}