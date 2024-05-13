namespace GravityBookstore.ModelsDto;

public class AddressDto
{
    public int Address_id { get; set; }
    public string Street_number { get; set; }
    public string Street_name { get; set; }
    public string City { get; set; }
    public int Country_id { get; set; }
}

public class AddressPostDto
{
    public string Street_number { get; set; }
    public string Street_name { get; set; }
    public string City { get; set; }
    public int Country_id { get; set; }
}
