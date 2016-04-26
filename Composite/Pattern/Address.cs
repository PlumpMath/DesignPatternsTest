using System.Collections.Generic;

namespace Composite.Pattern
{
    public class Address : IBusinessObject
    {
        private List<Phone> Phones = new List<Phone>();

        public IEnumerable<Phone> ChildObjects
        {
            get
            {
                return Phones;
            }
        }

        public void Add(IBusinessObject objPhone)
        {
            Phones.Add((Phone)objPhone);
        }

        public void Update()
        {
            System.Console.WriteLine("Промених се адрес");
        }

        public bool isValid()
        {
            return true;
        }
    }
}