using ApplicationBusiness.ParametrosModels;

namespace ApplicationInfra
{
    public static class Suporte
    {
        /// <summary>
        /// Guarda o usuário logado
        /// </summary>
        public static Usuario UsuarioLogado { get; set; }
        /// <summary>
        /// Guarda a empresa logada
        /// </summary>
        public static Empresa EmpresaLogada { get; set; }
    }

}
