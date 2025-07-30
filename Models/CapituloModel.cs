using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiQuadrinhos.Models;

public class CapituloModel
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public int Numero { get; set; }
    [Required]
    public Guid QuadrinhoId { get; set; }
    [ForeignKey("QuadrinhoId")]
    public virtual QuadrinhoModel Quadrinho { get; set; }

    public virtual ICollection<Pagina> Paginas { get; set; } = new List<Pagina>();

}