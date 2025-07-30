using ApiQuadrinhos.Models;

namespace ApiQuadrinhos.Repository.Interfaces;

public interface ICapituloRepository
{
    Task<List<CapituloModel>> GetAll();
    Task<CapituloModel> GetById(Guid id);
    Task<CapituloModel> Create(CapituloModel capitulo);
    Task<CapituloModel> Update(CapituloModel capitulo, Guid id);
    Task<bool> Delete(Guid id);
}