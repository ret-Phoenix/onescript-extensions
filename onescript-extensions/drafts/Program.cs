using System;
using ScriptEngine.HostedScript;
using ScriptEngine.HostedScript.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drafts
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new ScriptEngine.HostedScript.HostedScriptEngine();
            engine.Initialize();

            // Тут можно указать любой класс из компоненты
            engine.AttachAssembly(System.Reflection.Assembly.GetAssembly(typeof(onescript_extensions.AssemblyReflector.AssemblyReflector)));

            var MyRef = new onescript_extensions.AssemblyReflector.AssemblyReflector();
            MyRef.LoadAssembly(ScriptEngine.Machine.ValueFactory.Create(@"c:\work\portable\OneScript\lib\extensions\bin\onescript-extensions.dll"));
            var newdata = MyRef.GetAsmTypes();

            onescript_extensions.AssemblyReflector.AssemblyType curT = (onescript_extensions.AssemblyReflector.AssemblyType)newdata.Get(0);
            var PPP = curT.GetProperties();

            Console.WriteLine(newdata);

        }
    }
}
