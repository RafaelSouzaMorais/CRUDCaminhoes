using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDCaminhoes.Models
{
    [Table("Caminhoes")]
    public class Caminhao
    {
        [Column("IdCaminhao")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name ="Código")]

        public int IdCaminhao { get; set; }

        [Column("Modelo")]
        [Required]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Column("AnoFabricacao")]
        [Required]
        [StringLength(4)]
        [Display(Name = "Ano de Fabricacao")]
        public string AnoFabricacao { get; set; }

        [Column("AnoModelo")]
        [Required]
        [StringLength(4)]
        [Display(Name = "Ano do Modelo")]
        public string AnoModelo { get; set; }

        [Column("Nome")]
        [Required]
        [StringLength(25)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }



    }
}
