namespace GravityBookstore.ModelsDto;

public class CustOrderDto
{
    public int Order_id { get; set; }
    public DateTime Order_date { get; set; }
    public int Customer_id { get; set; }
    public int Shipping_id { get; set; }
    public int Dest_address_id { get; set; }
}


public class CustOrderPostDto
{
    public DateTime Order_date { get; set; }
    public int Customer_id { get; set; }
    public int Shipping_id { get; set; }
    public int Dest_address_id { get; set; }
}
