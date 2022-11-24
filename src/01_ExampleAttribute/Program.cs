using System.Reflection;
using System.Threading.Channels;
using attributes;
using attributes.Attributes;

ExampleClass example = new ExampleClass();
ExampleClass.Method();

// Анализ атрибутов.

Type type = typeof(ExampleClass);
object[]? attributes = null;

// Анализ атрибутов типа.

// Получаем все атрибуты заданного типа ExampleAttribute (false - без проверки базовых классов).
attributes = type.GetCustomAttributes(false);

foreach (object item in attributes)
{
    if (item is ExampleAttribute attribute)
        Console.WriteLine($"Анализ типа  : Number = {attribute.Number}, Date = {attribute.Date}");
}

// Анализ атрибутов метода.

// Получаем public static метод - Method.
MethodInfo? method = type.GetMethod("Method", BindingFlags.Public | BindingFlags.Static);

// Получаем все атрибуты заданного типа ExampleAttribute (false - без проверки базовых классов).
attributes = method?.GetCustomAttributes(typeof(ExampleAttribute), false);

foreach (var item in attributes!)
{
    if (item is ExampleAttribute attribute)
        Console.WriteLine($"Анализ метода  : Number = {attribute.Number}, Date = {attribute.Date}");
}

ReadKey();