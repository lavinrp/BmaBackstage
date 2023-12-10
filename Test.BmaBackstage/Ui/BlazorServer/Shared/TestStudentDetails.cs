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
            Student testStudent = new Student(
                name: "TestName",
                birthDay: DateTime.Now,
                progressions: new List<Progression>(),
                contracts: new List<StudentContract> { },
                emergencyContacts: new List<EmergencyContact> { },
                specialNeeds: new List<string> { },
                notes: new List<string> { });
            using var ctx = new Bunit.TestContext();
            var cut = ctx.RenderComponent<StudentDetails>(
                paramaters => paramaters
                    .Add(p => p.Student, testStudent)
                );
            cut.Find("h3").MarkupMatches("<h3>TestName</h3>");
        }
    }
}
