namespace attributes.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
internal class ExampleAttribute : Attribute
{
    public string Date { get; }
    public string Text { get; }

    // Позиционные параметры задаются формальными параметрами - public конструктора, класса атрибута.
    public ExampleAttribute(string text, string date)
    {
        Date = date;
        Text = text;
    }

    public void Method() => WriteLine("Метод класса Атрибута.");
}