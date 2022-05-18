using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using BmaBackstage.Ui.BlazorServer.Pages;
using Bunit;


namespace Test.BmaBackstage.Ui.BlazorServer.Pages
{
    internal class TestCounter
    {
        [Test]
        public void TestCounterIncrement()
        {
            using var ctx = new Bunit.TestContext();
            var cut = ctx.RenderComponent<Counter>();
            cut.Find("button").Click();
            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
    }
}
