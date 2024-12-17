public class Conta
{
    public int Id { get; set; }                                                                                                                                                                                                            
    public string Numero { get; set; } = string.Empty;
    public string Agencia { get; set; } = string.Empty;
    public int ClienteId { get; set; }      
    public decimal Saldo { get; set; }      
    public string Status { get; set; } = string.Empty;

    public required Cliente Cliente { get; set; }
}
