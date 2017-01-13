using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Testing;

namespace Timus1068.Sum.Tests {

    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class Timus1068SumTests {

        [Test]
        public void Timus1068Sum_1_5() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "-3" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

            // Assert
            result.Should().Be("-5");
        }
    }
}