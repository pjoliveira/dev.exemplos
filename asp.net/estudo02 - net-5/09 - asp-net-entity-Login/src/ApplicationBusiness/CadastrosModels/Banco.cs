using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationBusiness.CadastrosModels
{
    [Table("dcbanco")]
    public class Banco : BaseModel
    {

        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O código do banco é obrigatório")]
        [Display(Name = "Código Banco")]
        [MinLength(03)]
        [MaxLength(03)]
        public string Codigo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome do banco é obrigatório")]
        [Display(Name = "Nome do Banco")]
        [MinLength(20)]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome reduzido do banco é obrigatório")]
        [Display(Name = "Nome reduzido")]
        [MinLength(02)]
        [MaxLength(40)]
        public string Fantasia { get; set; }

        [Display(Name = "Empresa ID")]
        public string EmpresaId { get; set; }
    }
}
