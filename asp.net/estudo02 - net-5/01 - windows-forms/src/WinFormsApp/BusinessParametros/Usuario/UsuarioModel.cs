using System;
using System.ComponentModel.DataAnnotations;
using SistemaCore;

namespace BusinessParametros
{
    public class UsuarioModel : BaseModel
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O E-Mail deve ser informado.")]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A senha deve ser informada.")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O Nome deve ser informado.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(10)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Defina o tipo de usuário.")]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [StringLength(03)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "É um usuário ativo ou bloqueado.")]
        [Display(Name = "Ativo")]
        public string Ativo { get; set; }

        [DataType(DataType.Date)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe a data de cadatro.")]
        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Validade até")]
        public DateTime? DataValidade { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "quantidade de Dias que s senha expira.")]
        [Display(Name = "Dias para trcar a senha")]
        public int ExpiraDias { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Alteração da senha")]
        public DateTime? DataSenha { get; set; }

    }
}
