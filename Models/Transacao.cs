using ProcessamentoLogsTransacionais.Models;

public class Transacao
{
    public int Id { get; set; }               
    public int LogId { get; set; }            
    public int ContaId { get; set; }          
    public string Status { get; set; } = string.Empty;
    public decimal Valor { get; set; }        

    public required Log Log { get; set; }
    public required Conta Conta { get; set; }
}
