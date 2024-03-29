using MasterInMedia_GildedRose_RefactoringKata;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace GildedRose_RefactoringKataTest
{
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {
            var lines = File.ReadAllLines(Path.GetDirectoryName(Path.GetDirectoryName(
                                              Path.GetDirectoryName(Directory.GetCurrentDirectory()))) +
                                          "\\ThirtyDays.txt");

            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            var outputLines = output.Split("\r\n");
            for (var i = 0; i < Math.Min(lines.Length, outputLines.Length); i++)
            {
                Assert.AreEqual(lines[i], outputLines[i]);
            }
        }
    }
}