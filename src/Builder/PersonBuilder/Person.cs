namespace Builder.PersonBuilder;

public sealed class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"Hello, {Name} {Surname}";
    }
}
