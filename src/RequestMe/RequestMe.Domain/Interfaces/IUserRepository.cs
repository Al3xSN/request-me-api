using RequestMe.Domain.Entities;

namespace RequestMe.Domain.Interfaces;

public interface IUserRepository
{
    public Task<List<SongRequest>> GetUsersAsync();
    
    public Task<SongRequest> GetUserByIdAsync(int id);
    
    public Task<bool> AddUserAsync(SongRequest songRequest);
    
    public Task<bool> UpdateUserAsync(SongRequest songRequest);
    
    public Task DeleteUserAsync(int id);
}