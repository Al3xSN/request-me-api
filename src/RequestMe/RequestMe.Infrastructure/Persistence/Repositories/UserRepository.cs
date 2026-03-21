using RequestMe.Domain.Entities;
using RequestMe.Domain.Interfaces;

namespace RequestMe.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    public async Task<List<SongRequest>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<SongRequest> GetUserByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AddUserAsync(SongRequest songRequest)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateUserAsync(SongRequest songRequest)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteUserAsync(int id)
    {
        throw new NotImplementedException();
    }
}