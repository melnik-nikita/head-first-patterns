using Builder.PersonBuilder;

namespace Builder;

public interface ISpecifyPersonSurname
{
    IBuildPerson WithSurname(string surname);
}
