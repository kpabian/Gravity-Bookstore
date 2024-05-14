namespace GravityBookstore.ModelsDto;

public class CustomerDto
{
    public int Customer_id { get; set; }
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public string Email { get; set; }
}

public class CustomerPostDto
{
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public string Email { get; set; }
    public AddressPostDto Address { get; set; }
}
