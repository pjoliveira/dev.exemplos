using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationBusiness.ParametrosModels
{
    [Table("tgmunicipio")]
    public class Municipio : BaseModel
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O Nome do Município é obrigatório.")]
        [Display(Name = "Nome Município")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Display(Name = "Estado")]
        public int UfID { get; set; }        
        [ForeignKey("UfID")]            
        public Estado Estado { get; set; }

    }
}
