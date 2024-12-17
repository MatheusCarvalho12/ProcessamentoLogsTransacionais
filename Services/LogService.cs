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

        public async Task<ResponseModel<Log>> BuscarLogPorId(int logId)
        {
            ResponseModel<Log> response = new ResponseModel<Log>();

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var logBanco = await connection.QueryFirstOrDefaultAsync<Log>("SELECT * FROM Log WHERE Id = @Id", new {Id = logId });

                if (logBanco == null)
                {
                    response.Mensagem = "Nenhum Log localizado";
                    response.Status = false;
                    return response;
                }

                response.Dados = logBanco;
                response.Mensagem = "Log localizado com sucesso";
            }
            return response;
        }
    }
}