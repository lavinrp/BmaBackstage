using BmaBackstage.Domain.Entities;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Collections.Generic;


namespace Test.BmaBackstage.Domain.Entities
{
    internal class TestProgressionStage
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void TestProgressionStageStringConstructorSetsProperties()
        {
            string progressionStageName = "Test Name";
            ProgressionStage stage = new(progressionStageName);
            Assert.That(progressionStageName, Is.EqualTo(stage.Name));
            CollectionAssert.IsEmpty(stage.Requirements);
        }

        [Test]
        public void TestProgressionStageConstructorSetsProperties()
        {
            string progressionStageName = "Test Name";
            List<AbstractRequirement> requirements = new()
            {
                new Mock<AbstractRequirement>().Object
            };

            ProgressionStage stage = new(progressionStageName, requirements);
            Assert.That(progressionStageName, Is.EqualTo(stage.Name));
            CollectionAssert.IsNotEmpty(stage.Requirements);
            Assert.That(requirements, Is.EqualTo(stage.Requirements));
        }

        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(true, true, ExpectedResult = true)]
        public bool TestIsComplete(bool requirement1Passed, bool requirement2Passed)
        {
            Mock<AbstractRequirement> requirement1 = new();
            requirement1.Setup(foo => foo.HasPassed()).Returns(requirement1Passed);
            Mock<AbstractRequirement> requirement2 = new();
            requirement2.Setup(foo => foo.HasPassed()).Returns(requirement2Passed);
            string progressionStageName = "Test Name";
            List<AbstractRequirement> requirements = new()
            {
                requirement1.Object,
                requirement2.Object
            };
            ProgressionStage stage = new(progressionStageName, requirements);
            return stage.IsComplete();
        }

        [Test]
        public void TestIsCompleteNoRequirements()
        {
            string progressionStageName = "Test Name";
            List<AbstractRequirement> requirements = new();
            ProgressionStage stage = new(progressionStageName, requirements);
            Assert.That(stage.IsComplete());
        }
    }
}
