namespace GravityBookstore.Models;

public class Address
{
    public int Address_id { get; set; }
    public string Street_number { get; set; }
    public string Street_name { get; set; }
    public string City { get; set; }
    public Country Country { get; set; }
}