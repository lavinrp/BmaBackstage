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
            Assert.AreEqual(requirementName, requirement.Name);
            Assert.AreEqual(hasPassedRequirement, requirement.Passed);
        }

        [Test]
        public void TestManualApprovalRequirementDefaultsToNotPassed()
        {
            string requirementName = "test requirement";
            ManualApprovalRequirement requirement = new(requirementName);
            Assert.AreEqual(false, requirement.Passed);
        }

        [TestCase(false)]
        [TestCase(true)]
        public void TestHasPassed(bool hasPassedRequirement)
        {
            string requirementName = "test requirement";
            ManualApprovalRequirement requirement = new(requirementName, hasPassedRequirement);
            Assert.AreEqual(hasPassedRequirement, requirement.HasPassed());
            Assert.AreEqual(hasPassedRequirement, requirement.Passed);
        }

        [Test]
        public void TestCalculateCompletionPercentWithPassedState()
        {
            string requirementName = "test requirement";
            bool hasPassedRequirement = true;
            ManualApprovalRequirement requirement = new(requirementName, hasPassedRequirement);
            Assert.AreEqual(1.0, requirement.CalculateCompletionPercent());
        }

        [Test]
        public void TestCalculateCompletionPercentWithNotPassedState()
        {
            string requirementName = "test requirement";
            bool hasPassedRequirement = false;
            ManualApprovalRequirement requirement = new(requirementName, hasPassedRequirement);
            Assert.AreEqual(0.0, requirement.CalculateCompletionPercent());
        }
    }
}
