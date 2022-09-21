using AutomacaoBancaria.Domain.Core.Models;

namespace AutomacaoBancaria.Domain.Core.Interfaces.Adapters.Sql;

public interface IContaCorrenteServices
{
    Task<ContaCorrente> ValidarContaCorrente(ContaCorrente contaCorrente);
    Task<ContaCorrente> ConsultarExtrato(string cpf);
}