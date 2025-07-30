using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiQuadrinhos.Models;

public class QuadrinhoModel
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Nome { get; set; }
    [Required]
    public string Descricao { get; set; }
    [Required]
    public string Capa { get; set; }
    [Required]
    public Guid AutorId { get; set; }
    [ForeignKey("AutorId")]
    public virtual AutorModel AutorModel { get; set; }
    
    public virtual ICollection<CapituloModel> Capitulos { get; set; } = new List<CapituloModel>();
    public virtual ICollection<LikeModel> Likes { get; set; } = new List<LikeModel>();
}