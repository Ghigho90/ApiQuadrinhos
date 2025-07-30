using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiQuadrinhos.Models;

public class AutorModel
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public int Cpf { get; set; }
    [Required]
    public Guid UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual UserModel UserModel { get; set; }
    public virtual ICollection<QuadrinhoModel> Quadrinhos { get; set; } = new List<QuadrinhoModel>();
}