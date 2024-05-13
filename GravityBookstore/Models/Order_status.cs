using System.ComponentModel.DataAnnotations;

namespace GravityBookstore.Models;

public class Order_status
{
    [Key]
    public int Status_id { get; set; }
	public string Status_value { get; set; }
    public List<Order_history>? History { get; set; }
}