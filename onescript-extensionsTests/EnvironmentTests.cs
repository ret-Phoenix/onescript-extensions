using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptEngine.HostedScript;

namespace onescript_extensions.Tests
{
    [TestClass()]
    public class EnvironmentTests
    {

        private HostedScriptEngine _engine;

        public EnvironmentTests()
        {
            Engine = new HostedScriptEngine();
            Engine.Initialize();
        }

        public HostedScriptEngine Engine { get => _engine; set => _engine = value; }

        [TestMethod()]
        public void SystemDirectoryTest()
        {
            Engine.AttachAssembly(System.Reflection.Assembly.GetAssembly(typeof(onescript_extensions.Environment)));
            

            var env = new Environment();

            var drv = new DriveInfo.DriveInfo(@"c:\");
            System.Console.WriteLine(drv.AvailableFreeSpace);

            Assert.AreNotEqual(env.SystemDirectory, string.Empty);
            
        }

        
    }
}