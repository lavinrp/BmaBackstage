using BmaBackstage.Domain.Entities;
using NUnit.Framework;

namespace Test.BmaBackstage.Domain.Entities
{
    internal class TestManualApprovalRequirement
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
        public void TestManualApprovalRequirementConstructorSetsProperties()
        {
            string requirementName = "test requirement";
            bool hasPassedRequirement = true;
            ManualApprovalRequirement requirement = new(requirementName, hasPassedRequirement);
            Assert.That(requirementName, Is.EqualTo(requirement.Name));
            Assert.That(hasPassedRequirement, Is.EqualTo(requirement.Passed));
        }

        [Test]
        public void TestManualApprovalRequirementDefaultsToNotPassed()
        {
            string requirementName = "test requirement";
            ManualApprovalRequirement requirement = new(requirementName);
            Assert.That(false, Is.EqualTo(requirement.Passed));
        }

        [TestCase(false)]
        [TestCase(true)]
        public void TestHasPassed(bool hasPassedRequirement)
        {
            string requirementName = "test requirement";
            ManualApprovalRequirement requirement = new(requirementName, hasPassedRequirement);
            Assert.That(hasPassedRequirement, Is.EqualTo(requirement.HasPassed()));
            Assert.That(hasPassedRequirement, Is.EqualTo(requirement.Passed));
        }

        [Test]
        public void TestCalculateCompletionPercentWithPassedState()
        {
            string requirementName = "test requirement";
            bool hasPassedRequirement = true;
            ManualApprovalRequirement requirement = new(requirementName, hasPassedRequirement);
            Assert.That(1.0, Is.EqualTo(requirement.CalculateCompletionPercent()));
        }

        [Test]
        public void TestCalculateCompletionPercentWithNotPassedState()
        {
            string requirementName = "test requirement";
            bool hasPassedRequirement = false;
            ManualApprovalRequirement requirement = new(requirementName, hasPassedRequirement);
            Assert.That(0.0, Is.EqualTo(requirement.CalculateCompletionPercent()));
        }
    }
}
