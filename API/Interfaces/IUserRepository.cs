using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update (AppUser user);
        Task <bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task <AppUser> GetUserByIdAsync(int id);
        Task <AppUser> GetUserByName(string userName);
        Task <IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string userName);
    }
}