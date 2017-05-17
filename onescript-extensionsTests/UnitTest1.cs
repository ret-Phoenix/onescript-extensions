using System;
using System.IO;
using ScriptEngine.HostedScript;
using ScriptEngine.Machine;
using ScriptEngine.Environment;
using onescript_extensions;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptEngine.HostedScript;
using NUnitTests;
using System.IO;

namespace onescript_extensions.Tests
{
    [TestClass()]
    public class UnitTest1
    {

        private EngineHelpWrapper _host;

        public UnitTest1()
        {
            Host = new EngineHelpWrapper();
            Host.StartEngine();
            //host.RunTestScript("onescript-extensionsTests.Tests.driveinfo.os");
        }

        public EngineHelpWrapper Host { get => _host; set => _host = value; }

        [TestMethod()]
        public void TestMethod1()
        {
            //
            //Assert.Equals(1, 1);
            //Assert.AreEqual(1, 1);

        }
    }
}
