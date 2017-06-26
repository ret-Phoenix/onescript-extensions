using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;
using System;

namespace onescript_extensions.AssemblyReflector
{
    [ContextClass("ТипИзСборки", "TypeFromAssembly")]
    public class AssemblyType : AutoContext<AssemblyType>
    {

        private Type _asmType;

        private string _fullName;
        private string _name;
        private bool _isAbstract;
        private bool _isClass;
        private bool _isCOMObject;
        private bool _isEnum;
        private bool _isInterface;
        private bool _isNotPublic;
        private bool _isPublic;
        private bool _isSealed;
        private string _namespace;

        /// <summary>
        /// Информация по сборке
        /// </summary>
        /// <param name="type"></param>
        public AssemblyType(Type type)
        {
            AsmType = type;

            FullName = type.FullName;
            Name = type.Name;
            IsAbstract = type.IsAbstract;
            IsClass = type.IsClass;
            IsCOMObject = type.IsCOMObject;
            IsEnum = type.IsEnum;
            IsInterface = type.IsInterface;
            IsNotPublic = type.IsNotPublic;
            IsPublic = type.IsPublic;
            IsSealed = type.IsSealed;
            Namespace = type.Namespace;
        }

        /// <summary>
        /// Возвращает все открытые конструкторы, определенные для текущего объекта Type.
        /// </summary>
        /// <returns></returns>
        [ContextMethod("ПолучитьКонструкторы")]
        public ArrayImpl GetConstructors()
        {
            ArrayImpl result = new ArrayImpl();
            var constructors = AsmType.GetConstructors();
            foreach (var itm in constructors)
            {
                ArrayImpl miparams = new ArrayImpl();
                foreach(var prm in itm.GetParameters())
                {
                    StructureImpl strct = new StructureImpl();
                    strct.Insert("Имя", ValueFactory.Create(prm.Name));
                    strct.Insert("ЗначениеПоУмолчанию", ValueFactory.Create(prm.DefaultValue.ToString()));
                    strct.Insert("ЭтоНеобязательный", ValueFactory.Create(prm.IsOptional));
                    strct.Insert("Тип", ValueFactory.Create(prm.ParameterType.Name));

                    miparams.Add(strct);
                }

                AssemblyMethod mi = new AssemblyMethod();
                mi.Name = itm.Name;
                mi.IsFunction = false;
                mi.Params = miparams;
                result.Add(ValueFactory.Create(mi));
            }
            return result;
        }

        public  ArrayImpl GetEvents()
        {
            return new ArrayImpl();
        }

        [ContextMethod("ПолучитьПоля")]
        public ArrayImpl GetFields()
        {
            ArrayImpl result = new ArrayImpl();
            var list = AsmType.GetFields();
            foreach (var itm in list)
            {
                StructureImpl strct = new StructureImpl();
                strct.Insert("Имя", ValueFactory.Create(itm.Name));
                strct.Insert("Тип", ValueFactory.Create(itm.FieldType.Name));
                strct.Insert("ЭтоЗакрытое", ValueFactory.Create(itm.IsPrivate));
                strct.Insert("ЭтоОткрытое", ValueFactory.Create(itm.IsPublic));

                result.Add(strct);
            }
            return result;
        }

        public ArrayImpl GetMembers()
        {
            return new ArrayImpl();
        }

        [ContextMethod("ПолучитьМетоды", "GetMethods")]
        public ArrayImpl GetAsmMethods()
        {
            ArrayImpl result = new ArrayImpl();
            var list = AsmType.GetMethods();
            foreach (var itm in list)
            {
                ArrayImpl miparams = new ArrayImpl();
                foreach (var prm in itm.GetParameters())
                {
                    StructureImpl strct = new StructureImpl();
                    strct.Insert("Имя", ValueFactory.Create(prm.Name));
                    strct.Insert("ЗначениеПоУмолчанию", ValueFactory.Create(prm.DefaultValue.ToString()));
                    strct.Insert("ЭтоНеобязательный", ValueFactory.Create(prm.IsOptional));
                    strct.Insert("Тип", ValueFactory.Create(prm.ParameterType.Name));

                    miparams.Add(strct);
                }

                AssemblyMethod mi = new AssemblyMethod();
                mi.Name = itm.Name;
                mi.IsFunction = false;
                mi.IsConstructor = itm.IsConstructor;
                mi.IsPublic = itm.IsPublic;
                mi.ReturnParameter = itm.ReturnParameter.Name;
                mi.ReturnType = itm.ReturnType.Name;
                mi.Params = miparams;
                result.Add(ValueFactory.Create(mi));
            }
            return result;
        }

        [ContextMethod("ПолучитьСвойства", "GetProperties")]
        public ArrayImpl GetAsmProperties()
        {
            ArrayImpl result = new ArrayImpl();
            var list = AsmType.GetProperties();
            foreach (var itm in list)
            {
                StructureImpl strct = new StructureImpl();
                strct.Insert("Имя", ValueFactory.Create(itm.Name));
                strct.Insert("Тип", ValueFactory.Create(itm.PropertyType.Name));
                strct.Insert("ДоступноЧтение", ValueFactory.Create(itm.CanRead));
                strct.Insert("ДоступнаЗапись", ValueFactory.Create(itm.CanWrite));
                
                //strct.Insert("ИмяМетодаЧтения", ValueFactory.Create(itm.GetMethod.Name));
                //strct.Insert("ИмяМетодаЗаписи", ValueFactory.Create(itm.SetMethod.Name));

                result.Add(strct);
            }
            return result;
        }
            

        /// <summary>
        /// Возвращает полное имя типа, включая пространство имен, но не сборку.
        /// </summary>
        [ContextProperty("ПолноеИмя")]
        public string FullName { get { return _fullName; } set { _fullName = value; } }

        /// <summary>
        /// Возвращает имя текущего элемента
        /// </summary>
        [ContextProperty("Имя")]
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

        /// <summary>
        /// Возвращает значение, показывающее, является ли данный объект Type абстрактным объектом, который должен быть переопределен.
        /// </summary>
        [ContextProperty("ЭтоАбстрактный")]
        public bool IsAbstract
        {
            get
            {
                return _isAbstract;
            }

            set
            {
                _isAbstract = value;
            }
        }

        /// <summary>
        /// Получает значение, позволяющее определить, является объект Type классом или делегатом (иными словами, не является типом значения или интерфейсом).
        /// </summary>
        [ContextProperty("ЭтоКласс")]
        public bool IsClass
        {
            get
            {
                return _isClass;
            }

            set
            {
                _isClass = value;
            }
        }

        /// <summary>
        /// Возвращает значение, указывающее, является ли объект Type COM-объектом.
        /// </summary>
        [ContextProperty("ЭтоCOMОбъект")]
        public bool IsCOMObject
        {
            get
            {
                return _isCOMObject;
            }

            set
            {
                _isCOMObject = value;
            }
        }

        /// <summary>
        /// Возвращает значение, позволяющее определить, представляет ли текущий объект Type перечисление.
        /// </summary>
        [ContextProperty("ЭтоПеречисление")]
        public bool IsEnum
        {
            get
            {
                return _isEnum;
            }

            set
            {
                _isEnum = value;
            }
        }

        /// <summary>
        /// Возвращает значение, позволяющее определить, является ли объект Type интерфейсом (иными словами, не является классом или типом значения).
        /// </summary>
        [ContextProperty("ЭтоИнтерфейс")]
        public bool IsInterface
        {
            get
            {
                return _isInterface;
            }

            set
            {
                _isInterface = value;
            }
        }

        /// <summary>
        /// Возвращает значение, позволяющее определить, не был ли объект Type объявлен как открытый.
        /// </summary>
        [ContextProperty("ЭтоНеОткрытый")]
        public bool IsNotPublic
        {
            get
            {
                return _isNotPublic;
            }

            set
            {
                _isNotPublic = value;
            }
        }

        [ContextProperty("ЭтоОткрытый")]
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

        [ContextProperty("ЭтоНенаследуемый")]
        public bool IsSealed
        {
            get
            {
                return _isSealed;
            }

            set
            {
                _isSealed = value;
            }
        }

        [ContextProperty("ПространствоИмен")]
        public string Namespace
        {
            get
            {
                return _namespace;
            }

            set
            {
                _namespace = value;
            }
        }


        public Type AsmType
        {
            get
            {
                return _asmType;
            }

            set
            {
                _asmType = value;
            }
        }

        [ScriptConstructor]
        public static IRuntimeContextInstance Constructor(Type type)
        {
            return new AssemblyType(type);
        }
    }
}
