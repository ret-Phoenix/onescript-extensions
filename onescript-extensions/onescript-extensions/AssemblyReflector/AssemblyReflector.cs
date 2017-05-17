using ScriptEngine.HostedScript;
using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

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
            //HostedScriptEngine engine;
            //engine = new HostedScriptEngine();
            //engine.Initialize();
            //engine.AttachAssembly(System.Reflection.Assembly.GetAssembly(typeof(Object)));
            //_asm = Assembly.Load(asm.AsString());
            //_asm = Assembly.ReflectionOnlyLoad(asm.AsString());
            //AssemblyBuilder sd = new AssemblyBuilder();
            //sd.GetExportedTypes

            //AssemblyName aName = new AssemblyName(asm.AsString());
            //AssemblyBuilder ab =
            //    AppDomain.CurrentDomain.DefineDynamicAssembly(
            //        aName,
            //        AssemblyBuilderAccess.RunAndSave);

            AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += new ResolveEventHandler(CurrentDomain_ReflectionOnlyAssemblyResolve);
            Assembly assembly = Assembly.ReflectionOnlyLoad(asm.AsString());
            foreach (Type t in assembly.GetTypes())
            {
                Console.WriteLine(t.FullName);
            }

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
