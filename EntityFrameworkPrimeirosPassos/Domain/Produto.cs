using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Produto")]
    public class Produto
    {
        [Key]//Define o atributo chave
        public int Id { get; set; }

        [MaxLength(200)]//Limita o tamanho máximo
        [Required]//Define o atributo como NotNull(não vazio)
        public string Nome { get; set; }
        [MaxLength(2000)]//Limita o tamanho máximo
        public string Descricao { get; set; }
        [Range(-999999999999.99, 999999999999.99)]//Define o tamanho minimo e maximo do valor
        [Required]
        public decimal Valor { get; set; }
    }
}
