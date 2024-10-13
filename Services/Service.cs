public class Service
{ 
public Guid Id { get; }
    public Service()
    {
        Id = Guid.NewGuid();
    }
}