﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using CH.Testing.T3.Interface;
using FakeItEasy;
using NUnit.Framework;

namespace CH.Testing.T3.Test
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    class ResultOutputterTestFixture
    {
        [Test]
        public void Simple()
        {
            // Arrange
            var outputter = A.Fake<IOutputter>();
            var resultsSource = A.Fake<ISource<IEnumerable<string>>>();

            var resultOutputter = new Component.ResultOutputter(outputter, resultsSource);

            // Act
            resultOutputter.Output();

            // Assert

        }
    }
}
