public class SingletonProvider : IProvider
{
    public static Service? sample = null;
    public Service GetSample()
    {
        if (sample == null)
            sample = new Service();
        return sample;
    }
}