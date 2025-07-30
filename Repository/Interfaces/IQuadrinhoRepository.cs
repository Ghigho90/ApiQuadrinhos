using ApiQuadrinhos.Models;

namespace ApiQuadrinhos.Repository.Interfaces;

public interface IQuadrinhoRepository
{
    Task<List<QuadrinhoModel>> GetAll();
    Task<QuadrinhoModel> GetById(Guid id);
    Task<QuadrinhoModel> Create(QuadrinhoModel quadrinho);
    Task<QuadrinhoModel> Update(QuadrinhoModel quadrinho, Guid id);
    Task<bool> Delete(Guid id);
}