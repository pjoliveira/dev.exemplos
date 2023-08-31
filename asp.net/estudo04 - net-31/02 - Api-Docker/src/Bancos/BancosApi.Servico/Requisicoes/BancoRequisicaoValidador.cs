using FluentValidation;

namespace BancosAPI.Servico.Requisicoes
{
    public class BancoRequisicaoValidador : AbstractValidator<BancoRequisicao>
    {
        public BancoRequisicaoValidador()
        {
            RuleFor(banco => banco.Nome)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(banco => banco.Fantasia)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(banco => banco.ID)
                .NotEmpty()
                .MaximumLength(3);
        }
    }
}
