using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BmaBackstage.Ui.BlazorServer.Pages;
using Bunit;
using BmaBackstage.Ui.BlazorServer.Shared;
using Moq;
using BmaBackstage.Domain.Entities;

namespace Test.BmaBackstage.Ui.BlazorServer.Shared
{
    internal class TestStudentDetails
    {
        [Test]
        public void TestName()
        {
            Mock<IStudent> mockStudent = new();
            mockStudent.Setup(foo => foo.Name).Returns("TestName");
            using var ctx = new Bunit.TestContext();
            var cut = ctx.RenderComponent<StudentDetails>(
                paramaters => paramaters
                    .Add(p => p.Student, mockStudent.Object)
                );
            cut.Find("h4").MarkupMatches("<h4>TestName</h4>");
        }
    }
}
