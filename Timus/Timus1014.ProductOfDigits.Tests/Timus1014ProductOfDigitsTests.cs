using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Testing;

namespace Timus1014.ProductOfDigits.Tests {

    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class Timus1014ProductOfDigitsTests {
        [Test]
        public void Timus1014ProductOfDigitsTests_1_1() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "1" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main).Results[0];

            // Assert
            result.Should().Be("1");
        }

        [Test]
        public void Timus1014ProductOfDigitsTests_5_5() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "5" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main).Results[0];

            // Assert
            result.Should().Be("5");
        }

        [Test]
        public void Timus1014ProductOfDigitsTests_9_9() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "9" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main).Results[0];

            // Assert
            result.Should().Be("9");
        }

        [Test]
        public void Timus1014ProductOfDigitsTests_10_25() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "10" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main).Results[0];

            // Assert
            result.Should().Be("25");
        }

        [Test]
        public void Timus1014ProductOfDigitsTests_11_Minus1() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "11" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main).Results[0];

            // Assert
            result.Should().Be("-1");
        }
    }
}