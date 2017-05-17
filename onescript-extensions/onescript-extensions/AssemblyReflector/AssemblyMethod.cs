using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onescript_extensions.AssemblyReflector
{
    [ContextClass("МетодСборки", "AssemblyMethod")]
    class AssemblyMethod : AutoContext<AssemblyMethod>
    {
        private string _name;
        private bool _isFunction;
        private bool _isConstructor;
        private bool _isPublic;
        private string _returnParameter;
        private string _returnType;
        private ArrayImpl _params;

        [ContextProperty("Имя", "Name")]
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        [ContextProperty("ЭтоФункция")]
        public bool IsFunction
        {
            get
            {
                return _isFunction;
            }

            set
            {
                _isFunction = value;
            }
        }

        [ContextProperty("Параметры")]
        public ArrayImpl Params
        {
            get
            {
                return _params;
            }

            set
            {
                _params = value;
            }
        }

        [ContextProperty("ЭтоКонструктор")]
        public bool IsConstructor
        {
            get
            {
                return _isConstructor;
            }

            set
            {
                _isConstructor = value;
            }
        }

        [ContextProperty("ЭтоПубличный")]
        public bool IsPublic
        {
            get
            {
                return _isPublic;
            }

            set
            {
                _isPublic = value;
            }
        }

        [ContextProperty("ВозвращаемыйПараметр")]
        public string ReturnParameter
        {
            get
            {
                return _returnParameter;
            }

            set
            {
                _returnParameter = value;
            }
        }

        [ContextProperty("ВозвращаемоеЗначение")]
        public string ReturnType
        {
            get
            {
                return _returnType;
            }

            set
            {
                _returnType = value;
            }
        }

        public AssemblyMethod()
        {

        }
    }
}
