using Builder;
using Builder.EmployeeBuilder;

var kratos = new PersonStepWiseBuilder()
    .WithName("Kratos")
    .WithSurname("Zeusson")
    .Build();

var thor = PersonStepWiseBuilder
    .Create()
    .WithName("Thor")
    .WithSurname("Odinson")
    .Build();

Console.WriteLine(kratos);
Console.WriteLine(thor);

var employee = new EmployeeBuilder()
    .Works
    .At("Dish")
    .AsA("HR")
    .Earning(30000)
    .Lives
    .At("123 London Road")
    .In("London")
    .Postcode("12345")
    .Build();

Console.WriteLine(employee);
