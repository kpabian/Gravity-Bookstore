namespace GravityBookstore.ModelsDto;

public class OrderLineDto
{
    public int Line_id { get; set; }
    public int Cust_order_id { get; set; }
    public int Book_id { get; set; }
    public int Price { get; set; }
}

public class OrderLinePostDto
{
    public int Cust_order_id { get; set; }
    public int Book_id { get; set; }
    public int Price { get; set; }
}