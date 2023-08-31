using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationBusiness.ParametrosModels
{
    [Table("tgempresa")]
    public class Empresa : BaseModel
    {
        [Key]
        [StringLength(02, ErrorMessage = "Id da empresa não pode ter mais que 2 digitos")]
        [Required(ErrorMessage = "Informe o id para a empresa.")]
        [Display(Name = "ID")]
        public string ID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Informe a razão social.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Informe o nome fantasia.")]
        [Display(Name = "Fantasia")]
        public string Fantasia { get; set; }

    }
}
