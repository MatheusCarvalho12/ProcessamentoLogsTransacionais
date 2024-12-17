namespace ProcessamentoLogsTransacionais.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public DateTime DataContabil { get; set; }
    }
}
