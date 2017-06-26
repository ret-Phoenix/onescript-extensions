using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;
using ScriptEngine.Machine.Contexts;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace onescript_extensions
{
    [ContextClass("БуферОбмена", "Clipboard")]
    class Clipboard: AutoContext<Clipboard>
    {

        string clipboard;

        [ScriptConstructor]
        public static IRuntimeContextInstance Constructor()
        {
            return new Clipboard();
        }

        [STAThread]
        private void getClipboardBase()
        {
            if (System.Windows.Forms.Clipboard.ContainsText())
            {
                clipboard = System.Windows.Forms.Clipboard.GetText(TextDataFormat.UnicodeText);
            }
        }


        [ContextMethod("Получить", "Get")]
        public IValue GetClipboard()
        {
            Thread t = new Thread(getClipboardBase);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            while (t.IsAlive)
            {
            }
            return ValueFactory.Create(clipboard);
        }
    


        [ContextMethod("Установить", "Set")]
        public void SetClipboard(IValue val)
        {

            Thread thread = new Thread(() => System.Windows.Forms.Clipboard.SetText(val.AsString()));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join();
        }

    }
}
