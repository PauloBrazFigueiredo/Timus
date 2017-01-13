using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Testing.Console.Tests {

    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ConsoleTestes {

        [Test]
        public void Console_Main_1Input() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() {
                "1",
                "2 3"
            };
            Action<string[]> action = Program.Main;
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Action
            var result = consoleSimulator.Run(input, action, new string[] { });

            // Assert
            result.Should().NotBeNull();
            result.Results.Count.Should().Be(1);
            result.Results[0].Should().Be("5");
        }

        [Test]
        public void Console_Main_3Inputs() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() {
                "3",
                "2 3",
                "4 5",
                "6 7"
            };
            Action<string[]> action = Program.Main;
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Action
            var result = consoleSimulator.Run(input, action, new string[] { });

            // Assert
            result.Should().NotBeNull();
            result.Results.Count.Should().Be(3);
            result.Results[0].Should().Be("5");
            result.Results[1].Should().Be("9");
            result.Results[2].Should().Be("13");
        }
    }
}