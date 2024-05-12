using GravityBookstore.Models;

namespace GravityBookstore.ModelsDto
{
    public class OrderHistoryDto
    {
        public int History_id { get; set; }
        public int Cust_order_id { get; set; }
        public int Status_id { get; set; }
        public DateOnly Status_date { get; set; }
    }
}
