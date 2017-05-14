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
    [ContextClass("ИнформацияОДиске", "DriveInfo")]
    class DriveInfo : AutoContext<DriveInfo>
    {
        private System.IO.DriveInfo _driveInfo;
        public DriveInfo(string driveName)
        {
            _driveInfo = new System.IO.DriveInfo(driveName);
        }

        [ScriptConstructor]
        public static IRuntimeContextInstance Constructor(string driveName)
        {
            return new DriveInfo(driveName);
        }


        /// <summary>
        /// Указывает объем доступного свободного места на диске в байтах.
        /// </summary>
        [ContextProperty("Доступно")]
        public Int64 AvailableFreeSpace
        {
            get { return _driveInfo.AvailableFreeSpace; }
        }

        /// <summary>
        /// Получает имя файловой системы
        /// </summary>
        [ContextProperty("ИмяФС")]
        public string DriveFormat
        {
            get { return _driveInfo.DriveFormat; }
        }

        [ContextProperty("ТипДиска")]
        public IValue DriveType
        {
            get { return null//_driveInfo.DriveType
                    ; }
        }

        /// <summary>
        /// Получает значение, указывающее состояние готовности диска.
        /// </summary>
        [ContextProperty("Готов")]
        public bool IsReady
        {
            get
            {
                return _driveInfo.IsReady;
            }
        }

        /// <summary>
        /// Возвращает имя диска
        /// </summary>
        [ContextProperty("Имя")]
        public string Name
        {
            get
            {
                return _driveInfo.Name;
            }
        }

        /// <summary>
        /// Возвращает корневой каталог диска.
        /// </summary>
        [ContextProperty("КорневойКаталог")]
        public IValue RootDirectory
        {
            get
            {
                return new FileContext(_driveInfo.RootDirectory.FullName);
            }
        }

        /// <summary>
        /// Возвращает общий объем свободного места, доступного на диске, в байтах
        /// </summary>
        [ContextProperty("ОбщийОбъемСвободногоМеста")]
        public Int64 TotalFreeSpace
        {
            get { return _driveInfo.TotalFreeSpace; }
        }

        /// <summary>
        /// Возвращает общий размер места для хранения на диске в байтах.
        /// </summary>
        [ContextProperty("РазмерДиска")]
        public Int64 TotalSize
        {
            get { return _driveInfo.TotalSize; }
        }

        /// <summary>
        /// Возвращает или задает метку тома диска.
        /// </summary>
        [ContextProperty("МеткаТома")]
        public string VolumeLabel
        {
            get
            {
                return _driveInfo.VolumeLabel;
            }
            set
            {
                _driveInfo.VolumeLabel = value;
            }
        }

    }
}
