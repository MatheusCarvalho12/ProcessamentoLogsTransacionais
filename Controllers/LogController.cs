using Microsoft.AspNetCore.Mvc;
using ProcessamentoLogsTransacionais.Models;
using ProcessamentoLogsTransacionais.Services;

[ApiController]
[Route("api/[controller]")]
public class LogController : ControllerBase
{
    private readonly ILogInterface _logInterface;
    private readonly ITransacaoInterface _transacaoInterface;

    public LogController(ILogInterface logInterface, ITransacaoInterface transacaoInterface)
    {
        _logInterface = logInterface;
        _transacaoInterface = transacaoInterface;
    }

    [HttpGet]
    public async Task<IActionResult> BuscarLogs()
    {
        var result = await _logInterface.BuscarLogs();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarLogPorId(int id)
    {
        var result = await _logInterface.BuscarLogPorId(id);
        if (!result.Status)
            return NotFound(result);
        return Ok(result);
    } 

    [HttpGet("{logId}/transacoes")]
    public async Task<IActionResult> BuscarTransacaoPorId(int logId)
    {
        var result = await _transacaoInterface.BuscarTransacaoPorId(logId);
        return Ok(result);
    }
}
