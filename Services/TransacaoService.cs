using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProcessamentoLogsTransacionais.Models;
using System.Data;

namespace ProcessamentoLogsTransacionais.Services
{
    public class TransacaoService : ITransacaoInterface
    {
        private readonly IConfiguration _configuration;

        public TransacaoService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ResponseModel<List<Transacao>>> BuscarTransacaoPorId(int logId)
        {
            ResponseModel<List<Transacao>> response = new ResponseModel<List<Transacao>>();

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
               var transacoesBanco = await connection.QueryAsync<Transacao>("SELECT * FROM Transacoes WHERE LogId = @LogId", new { LogId = logId });
               if (transacoesBanco.Count() == 0)
                {
                    response.Mensagem = "Nenhuma transacao localizada";
                    response.Status = false;
                    return response;
               }

                response.Dados = transacoesBanco.ToList();
            }
            return response;
        }   
    }
}

