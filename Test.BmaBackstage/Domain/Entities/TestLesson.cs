using BmaBackstage.Domain.Entities;
using Moq;
using NUnit.Framework;
using System;

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
            Lesson lesson = new(mockInstructor.Object, date);
            Assert.AreEqual(lesson.Date, date);
            Assert.AreEqual(lesson.Instructor, mockInstructor.Object);
        }


    }
}
