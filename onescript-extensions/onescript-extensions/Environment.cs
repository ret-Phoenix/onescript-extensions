using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;

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
        /// 32-битовое целое число со знаком, которое возвращает количество процессоров на текущем компьютере. 
        /// Значение по умолчанию отсутствует. Если текущий компьютер содержит несколько групп процессоров, 
        /// данное свойство возвращает число логических процессоров, доступных для использования средой CLR
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

        /// <summary>
        /// Список специальных папок
        /// </summary>
        [ContextProperty("СпециальнаяПапка")]
        public IValue SpecialFolder
        {
            get
            {
                return new SpecialFolder();
            }
        }


        [ContextMethod("ПолучитьПутьПапки")]
        public string GetFolderPath(IValue folder)
        {
            return System.Environment.GetFolderPath((System.Environment.SpecialFolder)folder.AsNumber());
        }

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
