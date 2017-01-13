using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Testing;

namespace Timus2066.SimpleExpression.Tests {

    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class Timus2066SimpleExpressionTests {

        [Test]
        public void Timus1149SinusDances_1_2_3_Return_Minus5() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "1", "2", "3" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

            // Assert
            result.Should().Be("-5");
        }

        [Test]
        public void Timus1149SinusDances_25_50_100_Return_Minus4975() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "25", "50", "100" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

            // Assert
            result.Should().Be("-4975");
        }

        [Test]
        public void Timus1149SinusDances_0_0_100_Return_Minus4975() {
            // Assert
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "0", "0", "100" };
            var consoleSimulator = new ConsoleSimulator(consoleWrapper);

            // Act
            var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

            // Assert
            result.Should().Be("-100");
        }

        //[Test]
        //public void Timus1149SinusDances_1_3_3_Return_Minus8() {
        //    // Assert
        //    IConsoleWrapper consoleWrapper = new ConsoleWrapper();
        //    var input = new List<string>() { "1", "3", "3" };
        //    var consoleSimulator = new ConsoleSimulator(consoleWrapper);

        //    // Act
        //    var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

        //    // Assert
        //    result.Should().Be("-8");
        //}

        //[Test]
        //public void Timus1149SinusDances_1_1_3_Return_Minus2() {
        //    // Assert
        //    IConsoleWrapper consoleWrapper = new ConsoleWrapper();
        //    var input = new List<string>() { "1", "1", "3" };
        //    var consoleSimulator = new ConsoleSimulator(consoleWrapper);

        //    // Act
        //    var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

        //    // Assert
        //    result.Should().Be("-3");
        //}

        //[Test]
        //public void Timus1149SinusDances_2_2_2_Return_Minus2() {
        //    // Assert
        //    IConsoleWrapper consoleWrapper = new ConsoleWrapper();
        //    var input = new List<string>() { "2", "2", "2" };
        //    var consoleSimulator = new ConsoleSimulator(consoleWrapper);

        //    // Act
        //    var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

        //    // Assert
        //    result.Should().Be("-2");
        //}

        //[Test]
        //public void Timus1149SinusDances_0_0_0_Return_0() {
        //    // Assert
        //    IConsoleWrapper consoleWrapper = new ConsoleWrapper();
        //    var input = new List<string>() { "0", "0", "0" };
        //    var consoleSimulator = new ConsoleSimulator(consoleWrapper);

        //    // Act
        //    var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

        //    // Assert
        //    result.Should().Be("0");
        //}

        //[Test]
        //public void Timus1149SinusDances_0_0_1_Return_Minus1() {
        //    // Assert
        //    IConsoleWrapper consoleWrapper = new ConsoleWrapper();
        //    var input = new List<string>() { "0", "0", "1" };
        //    var consoleSimulator = new ConsoleSimulator(consoleWrapper);

        //    // Act
        //    var result = consoleSimulator.Run(input, Program.Main, new string[] { }).Results[0];

        //    // Assert
        //    result.Should().Be("-1");
        //}
    }
}