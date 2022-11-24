using attributes.Attributes;

namespace attributes;

[Example("31.12.2022", Number = 1)]
class ExampleClass
{
    [Example("01.01.2023", Number = 2)]
    public static void Method() => WriteLine("ExampleClass.Method\n");
}