/*
    Integrantes:

    Luiz Gustavo Verissimo Monteiro - CB3030326
    Kaik Persike Maiorquino - CB3029689
*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBTSWE2_TP03.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "Nome do produto necessário")]
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.00, double.MaxValue, 
            ErrorMessage =  "O preço não pode ser negativo.")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O estoque não pode ser negativo.")]
        public int QtdEstoque { get; set; }
    }
}
