using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiQuadrinhos.Models;

public class LikeModel
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public Guid UserId { get; set; }
    [Required]
    public Guid QuadrinhoId { get; set; }
    [ForeignKey("QuadrinhoId")]
    public virtual QuadrinhoModel Quadrinho { get; set; }
    [ForeignKey("UserId")]
    public virtual UserModel User { get; set; }
}