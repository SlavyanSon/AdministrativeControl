using AdministrativeControlLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativeControlLogic.Tests
{
    [TestClass()]
    public class IdleTimeFinderTests
    {
        [TestMethod()]
        public void GetIdleTimeTest()
        {
            var ticks = IdleTimeFinder.GetIdleTime();
            Console.WriteLine(ticks);
            Assert.IsTrue(ticks > 0);
        }
   
        [TestMethod()]
        public void GetLastInputTimeTest()
        {
            var ticks = IdleTimeFinder.GetLastInputTime();
            var timespent = TimeSpan.FromMilliseconds(ticks);
            Console.WriteLine(timespent);
            Assert.IsTrue(ticks > 0);
        }
    }
}