using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationBusiness.ParametrosModels
{
    [Table("tguf")]
    public class Estado : BaseModel
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O Nome da UF é obrigatório.")]
        [Display(Name = "Nome UF")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Sigla da UF é obrigatória.")]
        [Display(Name = "Sigla")]
        [StringLength(02)]
        public string Sigla { get; set; }

        [Display(Name = "País")]
        public int PaisID { get; set; }
        [ForeignKey("PaisID")]
        public Pais Pais { get; set; }


    }
}
