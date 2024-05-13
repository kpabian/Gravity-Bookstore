using System.ComponentModel.DataAnnotations;

namespace GravityBookstore.Models;

public class Country
{
    [Key]
    public int Country_id { get; set; }
    public string Country_name { get; set; }
    public List<Address>? Addresses { get; set; }

}

