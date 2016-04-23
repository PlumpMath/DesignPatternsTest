namespace Prototype.Customer
{
    public class Customer
    {
        public string Name = string.Empty;
        public string Code = string.Empty;
        public Address Address = new Address();

        public Customer GetClone()
        {
            Customer cust;
            cust = (Customer)MemberwiseClone();
            cust.Address = Address.GetClone();
            return cust;
        }
    }
}
