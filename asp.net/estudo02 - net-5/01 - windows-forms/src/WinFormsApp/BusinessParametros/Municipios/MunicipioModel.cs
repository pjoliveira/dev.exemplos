using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaCore; 

namespace BusinessParametros
{
    [Table("tgmunicipio")]
    public class MunicipioModel : BaseModel
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O Nome do Município é obrigatório.")]
        [Display(Name = "Nome Município")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Display(Name = "Estado")]
        public EstadoModel Estado { get; set; }

    }
}
