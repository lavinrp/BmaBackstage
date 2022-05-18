using BmaBackstage.Domain.Entities;
using Moq;
using NUnit.Framework;
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
            Assert.AreEqual(progressionStageName, stage.Name);
            Assert.IsEmpty(stage.Requirements);
        }

        [Test]
        public void TestProgressionStageConstructorSetsProperties()
        {
            string progressionStageName = "Test Name";
            List<IRequirement> requirements = new()
            {
                new Mock<IRequirement>().Object
            };

            ProgressionStage stage = new(progressionStageName, requirements);
            Assert.AreEqual(progressionStageName, stage.Name);
            Assert.IsNotEmpty(stage.Requirements);
            Assert.AreEqual(requirements, stage.Requirements);
        }

        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(true, true, ExpectedResult = true)]
        public bool TestIsComplete(bool requirement1Passed, bool requirement2Passed)
        {
            Mock<IRequirement> requirement1 = new();
            requirement1.Setup(foo => foo.HasPassed()).Returns(requirement1Passed);
            Mock<IRequirement> requirement2 = new();
            requirement2.Setup(foo => foo.HasPassed()).Returns(requirement2Passed);
            string progressionStageName = "Test Name";
            List<IRequirement> requirements = new()
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
            List<IRequirement> requirements = new();
            ProgressionStage stage = new(progressionStageName, requirements);
            Assert.IsTrue(stage.IsComplete());
        }
    }
}
