namespace GravityBookstore.ModelsDto;

public class OrderStatusDto
{
    public int Status_id { get; set; }
    public string Status_value { get; set; }
}

public class OrderStatusPostDto
{
    public string Status_value { get; set; }
}
