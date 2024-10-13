public class TransientProvider : IProvider
{ 
    public Service GetSample()
    {
        return new Service();
    }
}