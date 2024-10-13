public class Person
{
    // Constructor Injection 
    private Home _home;
    public Person(Home home)
    {
        _home = home;
    }

    // Property Injection
    private School _school;
    public School School
    { 
        set
        {
            _school = value;
        }
    }
    private College _college;
    public College College
    {
        set
        {
            _college = value;
        }
    }
    
    // Method Injection
    public void GetTreatment(Hospital hospital)
    {
        hospital.Cure(this);
    }
    public void Study()
    {
        if (_school != null)
            _school.Teach(this);
    }
    public void TakeRefugee()
    {
        _home.TakeRefugee(this);
    }
}