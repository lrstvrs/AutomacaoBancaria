using AutomacaoBancaria.Domain.Core.Models;

namespace AutomacaoBancaria.Domain.Core.Interfaces.Adapters.Sql;

public interface IContaCorrenteRepository
{
    Task CriarContaCorrente(ContaCorrente contaCorrente);
    Task<ContaCorrente> ConsultarConta(int agencia, int conta);
    Task<ContaCorrente> ConsultarAgencia(int agencia);
    Task<List<Log>> ConsultarExtrato(int agencia, int conta, DateTime dataInicialSql, DateTime dataFinalSql);
    Task<ContaCorrente> EfetivarDeposito(int agencia, int conta, decimal novoSaldo);
    Task<ContaCorrente> EfetivarSaque(int agencia, int conta, decimal novoSaldo);
    Task LogCredito(Log log);
    Task LogDebito(Log log);
}