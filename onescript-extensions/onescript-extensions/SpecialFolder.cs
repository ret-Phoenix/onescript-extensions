using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onescript_extensions
{
    [ContextClass("СпециальнаяПапка", "SpecialFolder")]
    class SpecialFolder : AutoContext<SpecialFolder>
    {

        [ContextProperty("МоиДокументы", "MyDocuments")]
        public int UsualGroup
        {
            get { return (int)SpecialFolderValue.MyDocuments; }
        }

        /// <summary>
        /// Логический рабочий стол, а не физическое местоположение файлов системы.
        /// </summary>
        [ContextProperty("РабочийСтол", "Desktop")]
        public int Desktop
        {
            get { return (int)SpecialFolderValue.Desktop; }
        }

        /// <summary>
        /// Папка Мой компьютер.
        /// </summary>
        [ContextProperty("МойКомпьютер", "MyComputer")]
        public int MyComputer
        {
            get { return (int)SpecialFolderValue.MyComputer; }
        }

        /// <summary>
        /// Каталог файлов программ.
        /// В системе не на базе x86 передача ProgramFiles методу GetFolderPath возвращает путь для программ не для 32-разрядных систем.
        /// Для получения каталога программных файлов x86 в системе не на базе x86 используйте член ProgramFilesX86.
        /// </summary>
        [ContextProperty("Программы", "Programs")]
        public int Programs
        {
            get { return (int)SpecialFolderValue.Programs; }
        }

        /// <summary>
        /// Каталог, служащий общим репозиторием для документов.
        /// </summary>
        [ContextProperty("РепозиторийДокументов", "Personal")]
        public int Personal
        {
            get { return (int)SpecialFolderValue.Personal; }
        }

        /// <summary>
        /// Каталог, служащий общим репозиторием для избранных элементов пользователя.
        /// </summary>
        [ContextProperty("Избранное", "Favorites")]
        public int Favorites
        {
            get { return (int)SpecialFolderValue.Favorites; }
        }

        /// <summary>
        /// Каталог, соответствующий группе программ пользователя «Автозагрузка».
        /// </summary>
        [ContextProperty("Автозагрузка", "Startup")]
        public int Startup
        {
            get { return (int)SpecialFolderValue.Startup; }
        }

        /// <summary>
        /// Каталог, содержащий недавно использовавшиеся документы.
        /// </summary>
        [ContextProperty("НедавниеДокументы", "Recent")]
        public int Recent
        {
            get { return (int)SpecialFolderValue.Recent; }
        }

        /// <summary>
        /// Каталог, содержащий пункты меню «Отправить».
        /// </summary>
        [ContextProperty("Отправить", "SendTo")]
        public int SendTo
        {
            get { return (int)SpecialFolderValue.SendTo; }
        }

        /// <summary>
        /// Каталог, содержащий пункты меню «Пуск».
        /// </summary>
        [ContextProperty("СтартовоеМеню", "StartMenu")]
        public int StartMenu
        {
            get { return (int)SpecialFolderValue.StartMenu; }
        }

        /// <summary>
        /// Папка Моя музыка.
        /// </summary>
        [ContextProperty("МояМузыка", "MyMusic")]
        public int MyMusic
        {
            get { return (int)SpecialFolderValue.MyMusic; }
        }

        /// <summary>
        /// Каталог, используемый для физического хранения файловых объектов рабочего стола.
        /// </summary>
        [ContextProperty("КаталогРабочийСтол", "DesktopDirectory")]
        public int DesktopDirectory
        {
            get { return (int)SpecialFolderValue.DesktopDirectory; }
        }

        /// <summary>
        /// Каталог, служащий общим репозиторием для шаблонов документов.
        /// </summary>
        [ContextProperty("Шаблоны", "Templates")]
        public int Templates
        {
            get { return (int)SpecialFolderValue.Templates; }
        }

        /// <summary>
        /// Каталог, выполняющий функции общего репозитория для данных приложения текущего перемещающегося пользователя.
        /// </summary>
        [ContextProperty("ДанныеПриложений", "ApplicationData")]
        public int ApplicationData
        {
            get { return (int)SpecialFolderValue.ApplicationData; }
        }

        /// <summary>
        /// Каталог, служащий общим репозиторием данных приложения, используемых текущим пользователем, который не перемещается.
        /// </summary>
        [ContextProperty("ЛокальныйКаталогДанныхПриложений", "LocalApplicationData")]
        public int LocalApplicationData
        {
            get { return (int)SpecialFolderValue.LocalApplicationData; }
        }

        /// <summary>
        /// Каталог, служащий общим репозиторием временных файлов Интернета.
        /// </summary>
        [ContextProperty("ИнтернетКеш", "InternetCache")]
        public int InternetCache
        {
            get { return (int)SpecialFolderValue.InternetCache; }
        }

        /// <summary>
        /// Каталог, служащий общим репозиторием файлов cookie Интернета.
        /// </summary>
        [ContextProperty("Куки", "Cookies")]
        public int Cookies
        {
            get { return (int)SpecialFolderValue.Cookies; }
        }

        /// <summary>
        /// Каталог, служащий общим репозиторием элементов журнала Интернета.
        /// </summary>
        [ContextProperty("История", "History")]
        public int History
        {
            get { return (int)SpecialFolderValue.History; }
        }

        /// <summary>
        /// Каталог, выполняющий функции общего репозитория для данных приложения, используемого всеми пользователями.
        /// </summary>
        [ContextProperty("ОбщийКаталогДанныхПриложения", "CommonApplicationData")]
        public int CommonApplicationData
        {
            get { return (int)SpecialFolderValue.CommonApplicationData; }
        }

        /// <summary>
        /// Каталог System
        /// </summary>
        [ContextProperty("Система", "System")]
        public int System
        {
            get { return (int)SpecialFolderValue.SendTo; }
        }


        /// <summary>
        /// Каталог файлов программ.
        ///  В системе не на базе x86 передача ProgramFiles методу GetFolderPath возвращает путь для программ не для 32-разрядных систем.
        ///  Для получения каталога программных файлов x86 в системе не на базе x86 используйте член ProgramFilesX86.
        /// </summary>
        [ContextProperty("ПрограммныеФайлы", "ProgramFiles")]
        public int ProgramFiles
        {
            get { return (int)SpecialFolderValue.ProgramFiles; }
        }

        /// <summary>
        /// Папка Мои рисунки.
        /// </summary>
        [ContextProperty("МоиРисунки", "MyPictures")]
        public int MyPictures
        {
            get { return (int)SpecialFolderValue.MyPictures; }
        }

        /// <summary>
        /// Каталог для компонентов, общих для приложений.
        /// Для получения общего каталога программных файлов x86 в системе не на базе x86 используйте член ProgramFilesX86.
        /// </summary>
        [ContextProperty("КаталогКомпонентовОбщихДляПриложений", "CommonProgramFiles")]
        public int CommonProgramFiles
        {
            get { return (int)SpecialFolderValue.CommonProgramFiles; }
        }

        /// <summary>
        /// Каталог файловой системы, служащий репозиторием файлов видеозаписей, принадлежащих пользователю
        /// </summary>
        [ContextProperty("МоиВидеозаписи", "MyVideos")]
        public int MyVideos
        {
            get { return (int)SpecialFolderValue.MyVideos; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий объекты ссылок, которые могут существовать в виртуальной папке Сетевое окружение.
        /// </summary>
        [ContextProperty("СетевоеОкружение", "NetworkShortcuts")]
        public int NetworkShortcuts
        {
            get { return (int)SpecialFolderValue.NetworkShortcuts; }
        }

        /// <summary>
        /// Виртуальная папка, содержащая шрифты.
        /// </summary>
        [ContextProperty("Шрифты", "Fonts")]
        public int Fonts
        {
            get { return (int)SpecialFolderValue.Fonts; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий программы и папки, отображающиеся в меню Пуск для всех пользователей. 
        /// </summary>
        [ContextProperty("ОбщийКаталогМенюПуск", "CommonStartMenu")]
        public int CommonStartMenu
        {
            get { return (int)SpecialFolderValue.CommonStartMenu; }
        }

        /// <summary>
        /// Каталог для компонентов, общих для приложений.
        /// Для получения общего каталога программных файлов x86 в системе не на базе x86 используйте член ProgramFilesX86.
        /// </summary>
        [ContextProperty("ОбщийКаталогКомпонентов", "CommonPrograms")]
        public int CommonPrograms
        {
            get { return (int)SpecialFolderValue.CommonPrograms; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий программы и папки, отображающиеся в папке Автозагрузка для всех пользователей.
        /// </summary>
        [ContextProperty("ОбщаяАвтозагрузка", "CommonStartup")]
        public int CommonStartup
        {
            get { return (int)SpecialFolderValue.CommonStartup; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий файлы и папки, отображающиеся на рабочих столах всех пользователей.
        /// </summary>
        [ContextProperty("ОбщийРабочийСтол", "CommonDesktopDirectory")]
        public int CommonDesktopDirectory
        {
            get { return (int)SpecialFolderValue.CommonDesktopDirectory; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий объекты ссылок, которые могут существовать в виртуальной папке Принтеры.
        /// </summary>
        [ContextProperty("Принтеры", "PrinterShortcuts")]
        public int PrinterShortcuts
        {
            get { return (int)SpecialFolderValue.PrinterShortcuts; }
        }

        /// <summary>
        /// Каталог Windows или SYSROOT. Это соответствует переменным среды %windir% и %SYSTEMROOT%.
        /// </summary>
        [ContextProperty("Windows", "Windows")]
        public int Windows
        {
            get { return (int)SpecialFolderValue.Windows; }
        }

        /// <summary>
        /// Папка профиля пользователя. Приложения не должны создавать файлы или папки на этом уровне; они должны помещать свои данные в местоположения, на которые указывает поле ApplicationData.
        /// </summary>
        [ContextProperty("ПрофильПользователя", "UserProfile")]
        public int UserProfile
        {
            get { return (int)SpecialFolderValue.UserProfile; }
        }

        /// <summary>
        /// Папка System ОС Windows
        /// </summary>
        [ContextProperty("СистемаХ86", "SystemX86")]
        public int SystemX86
        {
            get { return (int)SpecialFolderValue.SystemX86; }
        }

        /// <summary>
        /// Папка Program Files x86
        /// </summary>
        [ContextProperty("ПрограммныеФайлыХ86", "ProgramFilesX86")]
        public int ProgramFilesX86
        {
            get { return (int)SpecialFolderValue.ProgramFilesX86; }
        }

        /// <summary>
        /// Папка Program Files
        /// </summary>
        [ContextProperty("ОбщиеПрограммныеФайлы", "CommonProgramFilesX86")]
        public int CommonProgramFilesX86
        {
            get { return (int)SpecialFolderValue.CommonProgramFilesX86; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий шаблоны, доступные всем пользователям.
        /// </summary>
        [ContextProperty("ОбщиеШаблоны", "CommonTemplates")]
        public int CommonTemplates
        {
            get { return (int)SpecialFolderValue.CommonTemplates; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий документы, общие для всех пользователей
        /// </summary>
        [ContextProperty("ОбщиеДокументы", "CommonDocuments")]
        public int CommonDocuments
        {
            get { return (int)SpecialFolderValue.CommonDocuments; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий инструменты администрирования для всех пользователей компьютера
        /// </summary>
        [ContextProperty("ОбщиеАдминистрирование", "CommonAdminTools")]
        public int CommonAdminTools
        {
            get { return (int)SpecialFolderValue.CommonAdminTools; }
        }

        /// <summary>
        /// Каталог файловой системы, используемый для хранения инструментов администрирования для отдельного пользователя.
        /// Консоль управления (MMC) сохраняет настроенные консоли в этом каталоге, и он будет перемещаться вслед за пользователем. 
        /// </summary>
        [ContextProperty("Администрирование", "AdminTools")]
        public int AdminTools
        {
            get { return (int)SpecialFolderValue.AdminTools; }
        }

        /// <summary>
        /// Каталог файловой системы, служащий репозиторием музыкальных файлов, общих для всех пользователей.
        /// </summary>
        [ContextProperty("ОбщиеМузыка", "CommonMusic")]
        public int CommonMusic
        {
            get { return (int)SpecialFolderValue.CommonMusic; }
        }

        /// <summary>
        /// Каталог файловой системы, служащий репозиторием файлов изображений, общих для всех пользователей
        /// </summary>
        [ContextProperty("ОбщиеКартинки", "CommonPictures")]
        public int CommonPictures
        {
            get { return (int)SpecialFolderValue.CommonPictures; }
        }

        /// <summary>
        /// Каталог файловой системы, служащий репозиторием файлов видеозаписей, общих для всех пользователей
        /// </summary>
        [ContextProperty("ОбщееВидео", "CommonVideos")]
        public int CommonVideos
        {
            get { return (int)SpecialFolderValue.CommonVideos; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий данные ресурсов. 
        /// </summary>
        [ContextProperty("Ресурсы", "Resources")]
        public int Resources
        {
            get { return (int)SpecialFolderValue.Resources; }
        }

        /// <summary>
        /// Каталог файловой системы, содержащий локализованные данные ресурсов.
        /// </summary>
        [ContextProperty("ЛокализованныеРесурсы", "LocalizedResources")]
        public int LocalizedResources
        {
            get { return (int)SpecialFolderValue.LocalizedResources; }
        }

        /// <summary>
        /// Каталог файловой системы, выполняющий функции области промежуточного хранения для файлов, ожидающих записи на компакт-диск
        /// </summary>
        [ContextProperty("ОжидающиеЗаписиНаДиск", "CDBurning")]
        public int CDBurning
        {
            get { return (int)SpecialFolderValue.CDBurning; }
        }

       
    }


    enum SpecialFolderValue 
    {
        MyDocuments = 0x05,
        Desktop = 0x00,
        MyComputer = 0x11,
        Programs = 0x02,
        Personal = 0x05,
        Favorites = 0x06,
        Startup = 0x07,
        Recent = 0x08,
        SendTo = 0x09,
        StartMenu = 0x0b,
        MyMusic = 0x0d,
        DesktopDirectory = 0x10,
        Templates = 0x15,
        ApplicationData = 0x1a,
        LocalApplicationData = 0x1c,
        InternetCache = 0x20,
        Cookies = 0x21,
        History = 0x22,
        CommonApplicationData = 0x23,
        System = 0x25,
        ProgramFiles = 0x26,
        MyPictures = 0x27,
        CommonProgramFiles = 0x2b,
        MyVideos = 0x0e,
        NetworkShortcuts = 0x13,
        Fonts = 0x14,
        CommonStartMenu = 0x16,
        CommonPrograms = 0x17,
        CommonStartup = 0x18,
        CommonDesktopDirectory = 0x19,
        PrinterShortcuts = 0x1b,
        Windows = 0x24,
        UserProfile = 0x28,
        SystemX86 = 0x29,
        ProgramFilesX86 = 0x2a,
        CommonProgramFilesX86 = 0x2c,
        CommonTemplates = 0x2d,
        CommonDocuments = 0x2e,
        CommonAdminTools = 0x2f,
        AdminTools = 0x30,
        CommonMusic = 0x35,
        CommonPictures = 0x36,
        CommonVideos = 0x37,
        Resources = 0x38,
        LocalizedResources = 0x39,
        CommonOemLinks = 0x3a,
        CDBurning = 0x3b,
    }
}
