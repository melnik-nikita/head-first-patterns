using Builder.PersonBuilder;

namespace Builder;

public class PersonStepWiseBuilder
{
    private readonly PersonBuilderImplementation _personBuilderImplementation;

    private class PersonBuilderImplementation
        : ISpecifyPersonName, ISpecifyPersonSurname, IBuildPerson
    {
        private readonly Person _person;

        public PersonBuilderImplementation()
        {
            _person = new Person();
        }

        /// <inheritdoc />
        public ISpecifyPersonSurname WithName(string name)
        {
            _person.Name = name;

            return this;
        }

        /// <inheritdoc />
        public IBuildPerson WithSurname(string surname)
        {
            _person.Surname = surname;

            return this;
        }

        /// <inheritdoc />
        public Person Build()
        {
            return _person;
        }
    }

    public PersonStepWiseBuilder()
    {
        _personBuilderImplementation = new PersonBuilderImplementation();
    }

    public static ISpecifyPersonName Create()
    {
        return new PersonBuilderImplementation();
    }

    public ISpecifyPersonSurname WithName(string name)
    {
        return _personBuilderImplementation.WithName(name);
    }
}
