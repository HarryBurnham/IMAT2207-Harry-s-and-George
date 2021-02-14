namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public string OrderType { get; set; }
        public bool Dispatched { get; set; }
        public int CustomerId { get; set; }

    }
}