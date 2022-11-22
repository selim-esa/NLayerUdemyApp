namespace NLayer.Service.Services
{
    internal interface IUnitOfWork<T> where T : class
    {
        Task CommitAsync();
    }
}