using attributes.Attributes;

namespace attributes.Model;

[ExampleAttribute("XXX", "XX.XX.XXXX")]
internal class BaseClass
{
    public BaseClass() => WriteLine("Ctor BaseClass!!!");
}