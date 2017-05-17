using ScriptEngine.Machine.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onescript_extensions.DriveInfo
{
    [ContextClass("ТипДиска", "DriveType")]
    class DriveType : AutoContext<DriveType>
    {

        /// <summary>
        /// Диск является устройством оптических дисков, такие как компакт-ДИСК или DVD-диск.
        /// </summary>
        [ContextProperty("ОптическийДиск")]
        public int CDRom
        {
            get { return (int)System.IO.DriveType.CDRom; }
        }

        /// <summary>
        /// Диск является жестким диском.
        /// </summary>
        [ContextProperty("ЖесткийДиск")]
        public int Fixed
        {
            get { return (int)System.IO.DriveType.Fixed; }
        }

        /// <summary>
        /// Диск является сетевым диском.
        /// </summary>
        [ContextProperty("СетевойДиск")]
        public int Network
        {
            get { return (int)System.IO.DriveType.Network; }
        }

        /// <summary>
        /// Диск не имеет корневой каталог.
        /// </summary>
        [ContextProperty("НеИмеетКорневойКаталог")]
        public int NoRootDirectory
        {
            get { return (int)System.IO.DriveType.NoRootDirectory; }
        }

        /// <summary>
        /// Диск является диском ОЗУ.
        /// </summary>
        [ContextProperty("ДискОЗУ")]
        public int Ram
        {
            get { return (int)System.IO.DriveType.Ram; }
        }

        /// <summary>
        /// Диск является съемное запоминающее устройство, например, дисковод гибких дисков или USB-устройство флэш-памяти.
        /// </summary>
        [ContextProperty("СъемноеЗапоминающееУстройство")]
        public int Removable
        {
            get { return (int)System.IO.DriveType.Removable; }
        }

        /// <summary>
        /// Тип диска неизвестен.
        /// </summary>
        [ContextProperty("Неизвестный")]
        public int Unknown
        {
            get { return (int)System.IO.DriveType.Unknown; }
        }

    }
}
