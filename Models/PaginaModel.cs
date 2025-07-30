using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiQuadrinhos.Models;

public class PaginaModel
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Url { get; set; }
    [Required]
    public Guid CapituloId { get; set; }
    [ForeignKey("CapituloId")]
    public virtual CapituloModel Capitulo { get; set; }
}