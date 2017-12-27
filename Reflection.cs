using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


namespace Reflection
{
    class Program
    {
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
 {
 bool Result = false;
 attribute = null;
 //Поиск атрибутов с заданным типом
 var isAttribute = checkType.GetCustomAttributes(attributeType, false);
 if (isAttribute.Length > 0)
 {
 Result = true;
 attribute = isAttribute[0];
 }
 return Result;
 }

        static void Main(string[] args)
        {
            Type t = typeof(TestingClass);
            Console.WriteLine("Тип " + t.FullName + " унаследован от " +t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace);
            Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);
            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nПоля данных (public):");
            foreach (var x in t.GetFields())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nСвойства, помеченные атрибутом:");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(NewAttribute), out attrObj))
                {
                    NewAttribute attr = attrObj as NewAttribute;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
            Console.WriteLine("\nВызов метода:");
            TestingClass tc = (TestingClass)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });
            object[] parameters = new object[] { 3, 2 };
            object Result = t.InvokeMember("Sum", BindingFlags.InvokeMethod,
null, tc, parameters);
            Console.WriteLine("Sum(3,2)={0}", Result);
 Console.ReadLine();

        }
    }
}
