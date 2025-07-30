using System.ComponentModel.DataAnnotations;

namespace ApiQuadrinhos.Models;

public class UserModel
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Nome{ get; set; }
    [Required]
    [MaxLength(100)]
    public string Email { get; set; }
    [Required]
    public DateTime dtNascimento { get; set; }
}