using ProcessamentoLogsTransacionais.Models;

namespace ProcessamentoLogsTransacionais.Services
{
    public interface ITransacaoInterface
    {
        Task<ResponseModel<List<Transacao>>> BuscarTransacaoPorId(int logId);
    }
}
