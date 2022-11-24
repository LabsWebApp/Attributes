// ОТОБРАЖЕНИЕ ИНФОРМАЦИИ ОБ АТРИБУТЕ.
using System.Reflection;
using attributes.Attributes;
using attributes.Model;

// MemberInfo - абстрактный класс, используется для получения информации о членах класса. 
//Type type = typeof(ExampleClass);
MemberInfo type = typeof(ExampleClass);

// Метод GetCustomAttributes() - возвращает массив объектов, которые при выполнении приложения
// представляют собой эквиваленты атрибутов, созданных в исходном коде.
// Извлекаем из элементов массива элементы типа - ExampleAttribute.
object[] attributes = type.GetCustomAttributes(typeof(ExampleAttribute), true);

// Если в массиве есть соответствующие записи, то первый элемент представляет собой атрибут - ExampleAttribute.
if (attributes.GetLength(0) != 0)
{
    // Отображаем полученные значения.
    foreach (ExampleAttribute attribute in attributes)
    {
        WriteLine(attribute.Text);
        WriteLine(attribute.Date);
        attribute.Method();
    }
}

//Задержка.
ReadKey();