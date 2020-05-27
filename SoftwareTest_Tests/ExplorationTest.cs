using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareTestExamProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTest_Tests
{
    [TestClass]
    public class ExplorationTest
    {
        [TestMethod]
        public void Test()
        {
            ExplorationFunc func = new ExplorationFunc(4,  4);
        }
               
    }
}
