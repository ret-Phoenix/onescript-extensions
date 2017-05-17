using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptEngine.HostedScript;
using ScriptEngine.Environment;
using System.IO;

namespace onescript_extensionsTests
{
    [TestClass]
    public class UnitTest2
    {
        private HostedScriptEngine engine;

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

            return engine.Loader.FromString(codeSource);
        }


        public UnitTest2()
        {
            engine = new HostedScriptEngine();
            engine.Initialize();
            engine.AttachAssembly(System.Reflection.Assembly.GetAssembly(typeof(onescript_extensions.Environment)));

            //var testrunnerSource = LoadFromAssemblyResource("ExtensionsTests.Tests.testrunner.os");
            ICodeSource testrunnerSource = LoadFromAssemblyResource("onescript-extensionsTests.tests.driveinfo.os");
            //var testrunnerModule = engine.GetCompilerService().CreateModule(testrunnerSource);

        }

        [TestMethod]
        public void TestMethodMy1()
        {
            //Assert.AreEqual(1, 1);
        }
    }
}
