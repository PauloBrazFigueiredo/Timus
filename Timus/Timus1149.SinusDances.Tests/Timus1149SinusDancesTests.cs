using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Testing;

namespace Timus1149.SinusDances.Tests {

    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class Timus1149SinusDancesTests {

        [Test]
        public void Timus1149SinusDances_3() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "3" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

            // Assert
            result.Should().Be("((sin(1)+3)sin(1-sin(2))+2)sin(1-sin(2+sin(3)))+1");
        }
    }
}