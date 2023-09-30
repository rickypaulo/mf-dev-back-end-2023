using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mf_dev_back_end_2023.Models
{
    [Table("Veiculos")]    
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Obrigatorio informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a Placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Ano de Fabricacao!")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Ano do Modelo!")]
        public int AnoModelo { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Park4You.Models
{
    [Table("Parceiros")]
    public class Parceiro
    {
        [Key]
        private int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar o nome")]
        private string nomeParceiro { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar os Dados Bancarios")]
        private int dadosBancario { get; set; }

    }
}
