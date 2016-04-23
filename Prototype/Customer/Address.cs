namespace Prototype.Customer
{
    public class Address
    {
        public string Addr = string.Empty;
        public Address GetClone()
        {
            return (Address)MemberwiseClone();
        }
    }
}
