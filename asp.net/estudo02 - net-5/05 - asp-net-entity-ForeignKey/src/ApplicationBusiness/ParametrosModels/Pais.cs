using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationBusiness.ParametrosModels
{
    [Table("tgpais")]
    public class Pais : BaseModel
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Nome País")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Display(Name = "Sigla")]
        [StringLength(05)]
        public string Sigla { get; set; }

        public ICollection<Estado> Estados { get; set; }


    }
}
