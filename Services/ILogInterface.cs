using ProcessamentoLogsTransacionais.Models;

namespace ProcessamentoLogsTransacionais.Services
{
    public interface ILogInterface
    {
        Task<ResponseModel<List<Log>>> BuscarLogs();
    }
}
