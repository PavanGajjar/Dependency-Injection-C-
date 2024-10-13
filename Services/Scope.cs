public class Scope
{ 
    public IProvider TransientProvider { get; }
    public IProvider SingletonProvider { get; }
    public IProvider ScopedProvider { get; }
    public Scope()
    {
        SingletonProvider = new SingletonProvider();
        TransientProvider = new TransientProvider();
        ScopedProvider = new ScopedProvider();
    }
}