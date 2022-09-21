namespace Builder.PersonBuilder;

public interface ISpecifyPersonName
{
    ISpecifyPersonSurname WithName(string name);
}
