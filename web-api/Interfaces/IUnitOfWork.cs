using System.Threading.Tasks;

namespace web_api.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository {get; }
        Task<bool> SaveAsync();
    }
}