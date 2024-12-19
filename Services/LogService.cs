using Dapper;
using Microsoft.Data.SqlClient;
using ProcessamentoLogsTransacionais.Models;

namespace ProcessamentoLogsTransacionais.Services
{
    public class LogService : ILogInterface
    {
        private readonly IConfiguration _configuration;

        public LogService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ResponseModel<List<Log>>> BuscarLogs()
        {
            ResponseModel<List<Log>> response = new ResponseModel<List<Log>>();

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var logsBanco = await connection.QueryAsync<Log>("SELECT * FROM Log");
                if (logsBanco.Count() == 0)
                {
                    response.Mensagem = "Nenhum log localizado";
                    response.Status = false;
                    return response;
                }

                response.Dados = logsBanco.ToList();
            }
            return response;
        }
    }
}