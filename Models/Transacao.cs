using ProcessamentoLogsTransacionais.Models;
using static System.Net.Mime.MediaTypeNames;

public class Transacao
{
    public int Id { get; set; }               
    public int LogId { get; set; }            
    public int ContaId { get; set; }          
    public string Status { get; set; }        
    public decimal Valor { get; set; }        

    public Log Log { get; set; }
    public Conta Conta { get; set; }
}
