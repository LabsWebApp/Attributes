Person tom = new Person("Tom", 35);
Person bob = new Person("Bob", 16);
bool tomIsValid = ValidateUser(tom);    // true
bool bobIsValid = ValidateUser(bob);    // false

WriteLine($"Результат проверки Тома: {tomIsValid}");
WriteLine($"Результат проверки Боба: {bobIsValid}");

ReadKey();

bool ValidateUser(Person person)
{
    Type type = typeof(Person);
    // получаем все атрибуты класса Person
    object[] attributes = type.GetCustomAttributes(false);

    // проходим по всем атрибутам
    foreach (Attribute attr in attributes)
    {
        // если атрибут представляет тип AgeValidationAttribute
        if (attr is AgeValidationAttribute ageAttribute)
            // возвращаем результат проверки по возрасту
            return person.Age >= ageAttribute.Age;
    }
    return true;
}

class AgeValidationAttribute : Attribute
{
    public int Age { get; }
   // public AgeValidationAttribute() { }
    public AgeValidationAttribute(int age) => Age = age;
}

[AgeValidation(18)]
public class Person
{
    public string Name { get; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}