using BmaBackstage.Domain.Entities;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Test.BmaBackstage.Domain.Entities
{
    internal class TestAttendanceRequirement
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
        public void TestAttendanceRequirementConstructionSetsProperties()
        {
            string name = "test name";
            int requiredLessonCount = 10;
            List<Lesson> lessons = new()
            {
                new Lesson(new Mock<IInstructor>().Object, DateTime.Now)
            };
            AttendanceRequirement requirement = new(name, requiredLessonCount, lessons);
            Assert.AreEqual(name, requirement.Name);
            Assert.AreEqual(requiredLessonCount, requirement.RequiredLessonCount);
            Assert.AreEqual(lessons, requirement.Lessons);
        }

        [Test]
        public void TestHasPassedWithFiewerLessonsThanRequired()
        {
            string name = "test name";
            int requiredLessonCount = 10;
            List<Lesson> lessons = new()
            {
                new Lesson(new Mock<IInstructor>().Object, DateTime.Now)
            };
            AttendanceRequirement requirement = new(name, requiredLessonCount, lessons);
            Assert.IsFalse(requirement.HasPassed());
        }

        [Test]
        public void TestHasPassedWithExactlyTheLessonsRequired()
        {
            string name = "test name";
            int requiredLessonCount = 1;
            List<Lesson> lessons = new()
            {
                new Lesson(new Mock<IInstructor>().Object, DateTime.Now)
            };
            AttendanceRequirement requirement = new(name, requiredLessonCount, lessons);
            Assert.IsTrue(requirement.HasPassed());
        }

        [Test]
        public void TestHasPassedWithMoreLessonsThanRequired()
        {
            string name = "test name";
            int requiredLessonCount = 1;
            List<Lesson> lessons = new()
            {
                new Lesson(new Mock<IInstructor>().Object, DateTime.Now),
                new Lesson(new Mock<IInstructor>().Object, DateTime.Now),
            };
            AttendanceRequirement requirement = new(name, requiredLessonCount, lessons);
            Assert.IsTrue(requirement.HasPassed());
        }

        [TestCase(10, 1)]
        [TestCase(10, 2)]
        [TestCase(10, 9)]
        [TestCase(10, 10)]
        [TestCase(10, 11)]
        public void TestCalculateCompletionPercent(int requiredLessons, int actualLessons)
        {

            string name = "test name";
            List<Lesson> lessons = new();
            for (int i = 0; i < actualLessons; i++)
            {
                lessons.Add(new Lesson(new Mock<IInstructor>().Object, DateTime.Now));
            }

            AttendanceRequirement requirement = new(name, requiredLessons, lessons);
            double percent = requirement.CalculateCompletionPercent();

            if (requiredLessons > actualLessons)
            {
                Assert.AreEqual((double)actualLessons / requiredLessons, percent, 0.01);
            }
            else
            {
                Assert.AreEqual(1.0, percent, 0.01);
            }
        }
    }
}
