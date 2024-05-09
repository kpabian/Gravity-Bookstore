namespace GravityBookstore.Models;

public class Address
{
    public int Address_id { get; set; }
    public string Street_number { get; set; }
    public string Street_name { get; set; }
    public string City { get; set; }
    public int Country_id { get; set; }
    public Country Country { get; set; }
    public List<Customer_address> Customer_address { get; set; }
    public List<Cust_order> Cust_order { get; set; }
}