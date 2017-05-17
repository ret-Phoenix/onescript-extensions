using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnitTests;
using onescript_extensions;
using ScriptEngine.Environment;
using ScriptEngine.HostedScript;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onescript_extensions.Tests
{
    [TestClass()]
    public class InteractiveTests
    {
        private HostedScriptEngine _engine;

        public ICodeSource LoadFromAssemblyResource(string resourceName)
        {
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            string codeSource;

            using (Stream s = asm.GetManifestResourceStream(resourceName))
            {
                using (StreamReader r = new StreamReader(s))
                {
                    codeSource = r.ReadToEnd();
                }
            }

            return _engine.Loader.FromString(codeSource);
        }


        //private EngineHelpWrapper _host;


        public InteractiveTests()
        {
            Engine = new HostedScriptEngine();
            Engine.Initialize();
            Engine.AttachAssembly(System.Reflection.Assembly.GetAssembly(typeof(onescript_extensions.Interactive)));

            //_host = new EngineHelpWrapper();
            //_host.StartEngine();
        }

        public HostedScriptEngine Engine { get => _engine; set => _engine = value; }

        [TestMethod()]
        public void ConstructorTest()
        {
            //Assert.Equals(1, 1);
        }

        [TestMethod()]
        public void BeepTest()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod()]
        public void ClearMessagesTest()
        {
            //Assert.Equals(1, 1);
        }
    }
}