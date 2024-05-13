namespace GravityBookstore.ModelsDto;

public class AddressStatusDto
{
    public int Status_id { get; set; }
    public string Status_value { get; set; }
}

public class AddressStatusPostDto
{
    public string Status_value { get; set; }
}