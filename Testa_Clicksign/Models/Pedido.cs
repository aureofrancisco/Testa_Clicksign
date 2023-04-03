/*namespace Testa_Clicksign.Models*/
public class Pedido
{
    public int Id { get; set; }
    public int NumeroPedido { get; set; }
    public string? TextoDescritivo { get; set; }
    public DateTime DataPedido { get; set; }
    public string? StatusPedido { get; set; }
}
