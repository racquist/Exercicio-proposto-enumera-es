using System.Text;
using System.Globalization;


namespace Course.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double ParcialPrice { get; set; }
        public Product Product { get; set; } 

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double parcialPrice, Product product)
        {
            Quantity = quantity;
            ParcialPrice = parcialPrice;
            Product = product;
        }

        public double SubTotal()
        {
            return ParcialPrice * Quantity;
        }

       

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Quantity);
            sb.Append(" : ");
            sb.Append(ParcialPrice.ToString("F2", CultureInfo.InstalledUICulture));
            sb.Append(" : ");
            sb.Append(SubTotal().ToString("F2",CultureInfo.InvariantCulture));
            
            return sb.ToString();
        }
    }

}
