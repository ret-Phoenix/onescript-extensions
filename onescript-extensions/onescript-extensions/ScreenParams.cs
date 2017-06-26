using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;
using System.Drawing;
using System.Linq;

namespace onescript_extensions
{
    [ContextClass("ПараметрыЭкрана", "ScreenParams")]
    class ScreenParams : AutoContext<ScreenParams>
    {

        [ScriptConstructor]
        public static IRuntimeContextInstance Constructor()
        {
            return new ScreenParams();
        }

        /// <summary>
        /// Получить разрешение экрана
        /// </summary>
        /// <param name="SreenNumber">Число - Номер экрана, если ничего не задано - берет основной экран</param>
        /// <returns>ФиксированнаяСтруктура (Ширина, Высота)</returns>
        [ContextMethod("ПолучитьРазрешение")]
        public IValue GetResolution(int SreenNumber = 0)
        {

            Size resolution = System.Windows.Forms.Screen.AllScreens[SreenNumber].Bounds.Size;

            StructureImpl strct = new StructureImpl();
            strct.Insert("Ширина", ValueFactory.Create(resolution.Width));
            strct.Insert("Высота", ValueFactory.Create(resolution.Height));
            FixedStructureImpl FixStruct = new FixedStructureImpl(strct);

            return FixStruct;
        }

        /// <summary>
        /// Количество экранов
        /// </summary>
        /// <returns></returns>
        [ContextMethod("КоличествоЭкранов")]
        public int ScreensCount()
        {
            return System.Windows.Forms.Screen.AllScreens.Count();
        }

        /// <summary>
        /// Возвращает количество бит памяти
        /// </summary>
        /// <param name="SreenNumber">Число - Номер экрана, если ничего не задано - берет основной экран</param>
        /// <returns>Число</returns>
        [ContextMethod("КоличествоБит")]
        public int BitCount(int SreenNumber = 0)
        {
            return System.Windows.Forms.Screen.AllScreens[SreenNumber].BitsPerPixel;
        }

        /// <summary>
        /// Имя устройства
        /// </summary>
        /// <param name="SreenNumber">Число - Номер экрана, если ничего не задано - берет основной экран</param>
        /// <returns>Строка</returns>
        [ContextMethod("ИмяУстройства")]
        public string DeviceName(int SreenNumber = 0)
        {
            return System.Windows.Forms.Screen.AllScreens[SreenNumber].DeviceName;
        }


    }
}
