using Authentication.Entities;

namespace Authentication.Interfaces.Repositories;

public interface ILoginEntityRepository
{
    Task<LoginEntity> GetByIdAsync(int accountId);
    Task<LoginEntity> GetByUserIdAsync(string userId);
    Task<int> CreateAsync(LoginEntity login);
    Task UpdateAsync(LoginEntity login);
    Task DeleteAsync(int accountId);
}