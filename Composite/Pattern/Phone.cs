namespace Composite.Pattern
{
    public class Phone : IBusinessObject
    {
        public void Update()
        {
            System.Console.WriteLine("Промених се телефон");
        }

        public bool isValid()
        {
            return true;
        }

        public void Add(IBusinessObject o)
        {
            // no implementaton
        }
    }
}