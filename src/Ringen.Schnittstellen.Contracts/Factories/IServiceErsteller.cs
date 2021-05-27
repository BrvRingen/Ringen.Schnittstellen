namespace Ringen.Schnittstellen.Contracts.Factories
{
    public interface IServiceErsteller
    {
        T GetService<T>();
    }
}
