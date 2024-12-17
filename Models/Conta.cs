public class Conta
{
    public int Id { get; set; }                                                                                                                                                                                                            
    public string Numero { get; set; }
    public string Agencia { get; set; }      
    public int ClienteId { get; set; }      
    public decimal Saldo { get; set; }      
    public string Status { get; set; }        

    public Cliente Cliente { get; set; }
}
