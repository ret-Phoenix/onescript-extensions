using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace onescript_extensions
{
    [ContextClass("Интерактивность", "Interactive")]
    class Interactive : AutoContext<Interactive>
    {

        [ContextMethod("Сигнал")]
        public void Beep()
        {
            SystemSounds.Beep.Play();
        }

        [ContextMethod("ОчиститьСообщения")]
        public void ClearMessages()
        {
            Console.Clear();
        }

        
    }
}
