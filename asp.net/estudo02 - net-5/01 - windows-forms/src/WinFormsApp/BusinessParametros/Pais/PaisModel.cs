using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaCore;

namespace BusinessParametros
{
    [Table("tgpais")]
    public class PaisModel : BaseModel
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O Nome País é obrigatório.")]
        [Display(Name = "Nome País")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Sigla do País é obrigatório.")]
        [Display(Name = "Sigla")]
        [StringLength(05)]
        public string Sigla { get; set; }


    }
}
