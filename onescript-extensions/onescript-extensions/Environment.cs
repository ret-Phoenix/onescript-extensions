using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onescript_extensions
{
    [ContextClass("Окружение", "Environment")]
    public class Environment : AutoContext<Environment>
    {

        [ScriptConstructor]
        public static IRuntimeContextInstance Constructor()
        {
            return new Environment();
        }

        /// <summary>
        /// Возвращает полный путь к системному каталогу.
        /// </summary>
        [ContextProperty("СистемныйКаталог")]
        public string SystemDirectory
        {
            get { return System.Environment.SystemDirectory; }
        }

        /// <summary>
        /// Определяет, является ли текущая операционная система 64-разрядной.
        /// </summary>
        [ContextProperty("Это64БитнаяОперационнаяСистема")]
        public bool Is64BitOperatingSystem
        {
            get { return System.Environment.Is64BitOperatingSystem; }
        }

        /// <summary>
        /// Возвращает число процессоров.
        /// </summary>
        [ContextProperty("КоличествоПроцессоров")]
        public int ProcessorCount
        {
            get { return System.Environment.ProcessorCount; }
        }

        /// <summary>
        /// Возвращает количество байтов на странице памяти операционной системы
        /// </summary>
        [ContextProperty("РазмерСистемнойСтраницы")]
        public int SystemPageSize
        {
            get { return System.Environment.SystemPageSize; }
        }

        /// <summary>
        /// Возвращает время, истекшее с момента загрузки системы (в миллисекундах).
        /// </summary>
        [ContextProperty("ВремяРаботыСМоментаЗагрузки")]
        public int TickCount
        {
            get { return System.Environment.TickCount; }
        }

        /// <summary>
        /// Возвращает строковый массив, содержащий аргументы командной строки для текущего процесса.
        /// Массив строк, каждый элемент которого содержит аргумент командной строки. 
        /// Первым элементом является имя исполняемого файла. Последующие элементы, если они существуют, содержат аргументы командной строки.
        /// </summary>
        [ContextProperty("АргументыКоманднойСтроки")]
        public ArrayImpl CommandLineArgs
        {
            get {
                ArrayImpl arr = new ArrayImpl();
                var data = System.Environment.GetCommandLineArgs();
                foreach (var itm in data)
                {
                    arr.Add(ValueFactory.Create(itm));
                }
                return arr;
            }
        }

        
        //[ContextMethod("ПолучитьПутьПапки")]
        //public string GetFolderPath(IValue folder)
        //{
        //       return "";
        //}

        /// <summary>
        /// Возвращает массив строк, содержащий имена логических дисков текущего компьютера.
        /// </summary>
        [ContextProperty("ИменаЛогическихДисков")]
        public ArrayImpl GetLogicalDrives
        {
            get
            {
                ArrayImpl arr = new ArrayImpl();
                var data = System.Environment.GetLogicalDrives();
                foreach (var itm in data)
                {
                    arr.Add(ValueFactory.Create(itm));
                }
                return arr;
            }
        }

        

    }
}
