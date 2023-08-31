using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaCore; 

namespace BusinessCadastros
{
    [Table("dcclasse")]
    public class ClasseModel : BaseModel
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome da classe é obrigatório")]
        [Display(Name = "Nome")]
        [MinLength(02)]
        [MaxLength(60)]
        public string Nome { get; set; }

        [Display(Name = "Empresa ID")]
        public string EmpresaId { get; set; }

    }
}
