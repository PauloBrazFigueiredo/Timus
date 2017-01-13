using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Testing.Tests {

    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RunResultTests {

        [Test]
        public void RunResult_Constructor_CreateRunResult_ShouldCreateRunResult() {
            // Action
            var sut = new RunResult(new List<string>());

            // Assert
            sut.Should().NotBeNull();
        }
    }
}