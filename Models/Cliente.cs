using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccountPC2.Models
{
    [Table("t_cliente")]
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public long Id { get; set;} 
       public string? NombreT { get; set;} 
       public string? TipoC { get; set;} 
       public string? SaldoI { get; set;} 
       public string? Email { get; set;} 
    }
}