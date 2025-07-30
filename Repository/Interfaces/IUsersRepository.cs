using ApiQuadrinhos.Models;

namespace ApiQuadrinhos.Repository.Interfaces;

public interface IUsersRepository
{
    Task<List<UserModel>> GetAll();
    Task<UserModel> GetById(Guid id);
    Task<UserModel> Create(UserModel user);
    Task<UserModel> Update(UserModel user, Guid id);
    Task<bool> Delete(Guid id);
}