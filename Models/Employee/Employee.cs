class Employee : IEmployee
{ 
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Salary { get; set; }
    public string? Designation { get; set; }

    public Employee()
    {
        FirstName = "Pavan";
        LastName = "Gajjar";
        Salary = 1;
        Designation = "SE";
    }
}
interface IEmployee
{
    string? FirstName { get; set; }
    string? LastName { get; set; }
    int? Salary { get; set; }
    string? Designation { get; set; }
}