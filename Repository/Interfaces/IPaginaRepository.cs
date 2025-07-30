using ApiQuadrinhos.Models;

namespace ApiQuadrinhos.Repository.Interfaces;

public interface IPaginaRepository
{
    Task<List<PaginaModel>> GetPaginas(Guid id);
    Task<PaginaModel> GetPagina(Guid id);
    Task<PaginaModel> CreatePagina(PaginaModel pagina);
    Task<PaginaModel> UpdatePagina(PaginaModel pagina, Guid id);
    Task<bool> DeletePagina(Guid id);
}