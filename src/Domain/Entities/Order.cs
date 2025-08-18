namespace Domain;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime Date { get; set; }
    public OrderStatus Status { get; set; }
}

public enum OrderStatus
{
    Novo,
    Processando,
    Finalizado
}