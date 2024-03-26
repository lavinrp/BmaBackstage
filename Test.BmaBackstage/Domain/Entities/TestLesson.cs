using BmaBackstage.Domain.Entities;
using BmaBackstage.Domain.Entities.People;
using Moq;
using NUnit.Framework;
using System;
using Test.BmaBackstage.TestUtilities;

namespace Test.BmaBackstage.Domain.Entities
{
    internal class TestLesson
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
        public void TestLessonConstructorSetsProperties()
        {
            Mock<IInstructor> mockInstructor = new();
            DateTime date = DateTime.Now;
            Lesson lesson = new(FakePersonFactory.MakeRandomInstructor(), date);
            Assert.That(lesson.Date, Is.EqualTo(date));
            Assert.That(lesson.Instructor, Is.EqualTo(mockInstructor.Object));
        }


    }
}
