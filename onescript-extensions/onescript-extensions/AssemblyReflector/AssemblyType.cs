using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onescript_extensions.AssemblyReflector
{
    [ContextClass("ТипИзСборки", "TypeFromAssembly")]
    public class AssemblyType : AutoContext<AssemblyType>
    {

        private string _fullName;

        public AssemblyType(Type type)
        {
            FullName = type.FullName;
        }

        [ContextProperty("ПолноеИмя")]
        public string FullName { get => _fullName; set => _fullName = value; }

        [ScriptConstructor]
        public static IRuntimeContextInstance Constructor(Type type)
        {
            return new AssemblyType(type);
        }
    }
}
