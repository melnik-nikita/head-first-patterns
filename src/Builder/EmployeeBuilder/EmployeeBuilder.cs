namespace Builder.EmployeeBuilder;

public class EmployeeBuilder
{
    protected Employee Employee = new ();

    public EmployeeAddressBuilder Lives => new (Employee);
    public EmployeePositionBuilder Works => new (Employee);

    public EmployeeBuilder()
    {
        Employee = new Employee();
    }

    public Employee Build()
    {
        return Employee;
    }
}

public class EmployeeAddressBuilder : EmployeeBuilder
{
    public EmployeeAddressBuilder(Employee employee)
    {
        Employee = employee;
    }

    public EmployeeAddressBuilder At(string address)
    {
        Employee.StreetAddress = address;

        return this;
    }

    public EmployeeAddressBuilder In(string city)
    {
        Employee.City = city;

        return this;
    }

    public EmployeeAddressBuilder Postcode(string postcode)
    {
        Employee.PostCode = postcode;

        return this;
    }
}

public class EmployeePositionBuilder : EmployeeBuilder
{
    public EmployeePositionBuilder(Employee employee)
    {
        Employee = employee;
    }

    public EmployeePositionBuilder At(string companyName)
    {
        Employee.CompanyName = companyName;

        return this;
    }

    public EmployeePositionBuilder AsA(string position)
    {
        Employee.Position = position;

        return this;
    }

    public EmployeePositionBuilder Earning(int income)
    {
        Employee.AnnualIncome = income;

        return this;
    }
}
