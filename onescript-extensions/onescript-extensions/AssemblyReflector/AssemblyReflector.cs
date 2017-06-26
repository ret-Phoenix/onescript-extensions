using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;

using System;
using System.Reflection;

namespace onescript_extensions.AssemblyReflector
{
    [ContextClass("РефлекторСборок", "AssemblyReflector")]
    public class AssemblyReflector : AutoContext<AssemblyReflector>
    {
        private Assembly _asm;

        [ScriptConstructor]
        public static IRuntimeContextInstance Constructor()
        {
            return new AssemblyReflector();
        }

        /// <summary>
        /// Загрузить сборку
        /// </summary>
        /// <param name="asm">Строка - Путь к файлу сборки</param>
        [ContextMethod("ЗагрузитьСборку")]
        public void LoadAssembly(IValue asm)
        {
            _asm = Assembly.LoadFrom(asm.AsString());
        }

        public Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
        {
            Console.WriteLine("load:" + args.Name);
            return System.Reflection.Assembly.ReflectionOnlyLoad(args.Name);
        }

        /// <summary>
        /// Получить типы сборки
        /// </summary>
        /// <returns>Массив - Массив с типами сборки</returns>
        [ContextMethod("ПолучитьТипы", "GetTypes")]
        public ArrayImpl GetAsmTypes()
        {
            ArrayImpl types = new ArrayImpl();
            foreach(var itm in _asm.GetTypes())
            {
                AssemblyType type = new AssemblyType(itm);
                types.Add(type);
            }
            return types;
        }

    }
}
