using ProcessamentoLogsTransacionais.Models;

namespace ProcessamentoLogsTransacionais.Services
{
    public interface ILogInterface
    {
        Task<ResponseModel<List<Log>>> BuscarLogs();
        Task<ResponseModel<Log>> BuscarLogPorId(int id);
    }
}
