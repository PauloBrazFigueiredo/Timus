using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Testing;

namespace Timus1877.BicycleCodes.Tests {

    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class Timus1877BicycleCodesTests {

        [Test]
        public void Timus1877_0000_0001_no() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "0001", "0000" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

            // Assert
            result.Should().Be("no");
        }

        [Test]
        public void Timus1877_0002_0001_yes() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "0002", "0001" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

            // Assert
            result.Should().Be("yes");
        }
    }
}