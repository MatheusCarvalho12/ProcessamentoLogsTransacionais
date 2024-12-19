namespace ProcessamentoLogsTransacionais.Models
{
    public class ResponseModel<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = "success";
        public bool Status { get; set; } = true;
    }
}
