using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyAttributes
{
    internal class Program
    {
        static void Main()
        {
            // Получение сборки (Assembly assembly) код которой выполняется в данный моемент.
            Assembly assembly = Assembly.GetExecutingAssembly();
            // Полное имя сборки.
            Console.WriteLine($"Assembly Full Name:\n{assembly.FullName}");

            // AssemblyName объект, который позволяет разбить полное имя сборки на части.
            AssemblyName assemblyName = assembly.GetName();

            Console.WriteLine($"\nName: {assemblyName.Name}");                                           // Имя сборки
            Console.WriteLine($"Version: {assemblyName.Version.Major}.{assemblyName.Version.Minor}");    // Версия сборки.
            Console.WriteLine($"\nAssembly CodeBase: \n{assembly.CodeBase}");                            // Место хранения сборки.

            // Точка входа сборки AssemblyAttributes.
            Console.WriteLine("\nAssembly entry point:");

            Console.WriteLine(assembly.EntryPoint);

            // Задержка.
            Console.ReadKey();
        }
    }
}
