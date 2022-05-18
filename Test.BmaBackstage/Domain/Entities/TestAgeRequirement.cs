using BmaBackstage.Domain.Entities;
using Moq;
using NUnit.Framework;
using System;

namespace Test.BmaBackstage.Domain.Entities
{
    internal class TestAgeRequirement
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
        public void TestAgeRequirementConstructionSetsAgeAndName()
        {
            int currentAge = 10;
            int requiredAge = 20;

            var currentDate = DateTime.Now;
            var pastDate = currentDate.AddYears(-currentAge);
            Mock<IPerson> mockPerson = new();
            mockPerson.Setup(foo => foo.BirthDay).Returns(pastDate);
            string requirementName = "requirement name";
            AgeRequirement requirement = new(requirementName, requiredAge, mockPerson.Object);
            Assert.AreEqual(requiredAge, requirement.RequiredAge);
            Assert.AreEqual(requirementName, requirement.Name);
        }

        [Test]
        public void TestHasPassedWhenAgeIsBelowRequiredAge()
        {
            int currentAge = 10;
            int requiredAge = 20;

            var currentDate = DateTime.Now;
            var pastDate = currentDate.AddYears(-currentAge);
            Mock<IPerson> mockPerson = new();
            mockPerson.Setup(foo => foo.BirthDay).Returns(pastDate);
            AgeRequirement requirement = new("test", requiredAge, mockPerson.Object);
            Assert.IsFalse(requirement.HasPassed());
        }

        [Test]
        public void TestHasPassedWhenAgeIsExactlyRequiredAge()
        {
            int currentAge = 20;
            int requiredAge = 20;

            var currentDate = DateTime.Now;
            var pastDate = currentDate.AddYears(-currentAge);
            Mock<IPerson> mockPerson = new();
            mockPerson.Setup(foo => foo.BirthDay).Returns(pastDate);
            AgeRequirement requirement = new("test", requiredAge, mockPerson.Object);
            Assert.IsTrue(requirement.HasPassed());
        }

        [Test]
        public void TestHasPassedWhenAgeIsAboveRequiredAge()
        {
            int currentAge = 25;
            int requiredAge = 20;

            var currentDate = DateTime.Now;
            var pastDate = currentDate.AddYears(-currentAge);
            Mock<IPerson> mockPerson = new();
            mockPerson.Setup(foo => foo.BirthDay).Returns(pastDate);
            AgeRequirement requirement = new("test", requiredAge, mockPerson.Object);
            Assert.IsTrue(requirement.HasPassed());
        }

        [TestCase(10, 1)]
        [TestCase(10, 2)]
        [TestCase(10, 9)]
        [TestCase(10, 10)]
        [TestCase(10, 11)]
        public void TestCalculateCompletionPercent(int requiredAge, int actualAge)
        {
            var currentDate = DateTime.Now;
            var pastDate = currentDate.AddYears(-actualAge);
            Mock<IPerson> mockPerson = new();
            mockPerson.Setup(foo => foo.BirthDay).Returns(pastDate);
            AgeRequirement requirement = new("test", requiredAge, mockPerson.Object);
            double percent = requirement.CalculateCompletionPercent();
            if (requiredAge > actualAge)
            {
                Assert.AreEqual((double)actualAge / requiredAge, percent, 0.01);
            }
            else
            {
                Assert.AreEqual(1.0, percent, 0.01);
            }
        }
    }
}
