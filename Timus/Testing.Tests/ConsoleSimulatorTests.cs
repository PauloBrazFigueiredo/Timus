using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Testing.Tests {

    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ConsoleSimulatorTests {

        [Test]
        public void ConsoleSimulator_Constructor_CreateConsoleSimulator_ShouldCreateConsoleSimulator() {
            // Arrange
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();

            // Action
            var sut = new ConsoleSimulator(consoleWrapper);

            // Assert
            sut.Should().NotBeNull();
        }

        [Test]
        public void ConsoleSimulator_Constructor_CreateConsoleSimulatorWithNullConsoleWrapper_ShouldThrowArgumentNullException() {
            // Arrange
            IConsoleWrapper consoleWrapper = null;

            // Action
            Action action = () => new ConsoleSimulator(consoleWrapper);

            // Assert
            action.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void ConsoleSimulator_Run_RunMethod_ShouldReturn1RunResult() {
            // Arrange
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>();
            Action<string[]> method = (string[] x) => { Console.WriteLine(string.Empty); };
            var sut = new ConsoleSimulator(consoleWrapper);

            // Action
            var result = sut.Run(input, method, new string[] { });

            // Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<RunResult>();
        }

        [Test]
        public void ConsoleSimulator_Run_RunMethodReturning1String_ShouldReturnListWith1String() {
            // Arrange
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>();
            Action<string[]> method = (string[] x) => { Console.WriteLine("TEST"); };
            var sut = new ConsoleSimulator(consoleWrapper);

            // Action
            var result = sut.Run(input, method, new string[] { });

            // Assert
            result.Should().NotBeNull();
            result.Results.Count.Should().Be(1);
            result.Results[0].Should().Be("TEST");
        }

        [Test]
        public void ConsoleSimulator_Run_RunMethodReturning2Strings_ShouldReturnListWith2Strings() {
            // Arrange
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>();
            Action<string[]> method = (string[] x) => { Console.WriteLine("TEST1"); Console.WriteLine("TEST2"); };
            var sut = new ConsoleSimulator(consoleWrapper);

            // Action
            var result = sut.Run(input, method, new string[] { });

            // Assert
            result.Should().NotBeNull();
            result.Results.Count.Should().Be(2);
            result.Results[0].Should().Be("TEST1");
            result.Results[1].Should().Be("TEST2");
        }

        [Test]
        public void ConsoleSimulator_Run_RunMethodReturning2ReceivedinputStrings_ShouldReturnListWith2Strings() {
            // Arrange
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var input = new List<string>() { "INPUT1", "INPUT2" };
            Action<string[]> method = (string[] x) => { Console.WriteLine(Console.ReadLine()); Console.WriteLine(Console.ReadLine()); };
            var sut = new ConsoleSimulator(consoleWrapper);

            // Action
            var result = sut.Run(input, method, new string[] { });

            // Assert
            result.Should().NotBeNull();
            result.Results.Count.Should().Be(2);
            result.Results[0].Should().Be("INPUT1");
            result.Results[1].Should().Be("INPUT2");
        }
    }
}