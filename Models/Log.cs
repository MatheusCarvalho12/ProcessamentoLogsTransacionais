namespace ProcessamentoLogsTransacionais.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Origem { get; set; } = string.Empty;
        public DateTime DataContabil { get; set; }
    }
}
