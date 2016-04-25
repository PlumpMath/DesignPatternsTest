using System.Collections.Generic;

namespace Iterator.Iterators
{
    public class Iterator
    {
        private int CurrentIndex = 0;
        private List<Customer> CustomerList = new List<Customer>();

        public void FillList()
        {
            for (int i = 0; i < 10; i++)
            {
                CustomerList.Add(new Customer()
                {
                    Id = i,
                    Name = $"Просто Име {i}"
                });
            }
        }

        public Customer this[int index]
        {
            get
            {
                CurrentIndex = index;
                if (index < CustomerList.Count && index >= 0)
                {
                    return CustomerList[index];
                }
                else
                {
                    CurrentIndex = 0;
                    return null;
                }
            }
        }

        public Customer Prev()
        {
            return this[CurrentIndex - 1];
        }

        public Customer Next()
        {
            return this[CurrentIndex + 1];
        }

        public Customer First()
        {
            return this[0];
        }

        public Customer Last()
        {
            return this[CustomerList.Count - 1];
        }
    }
}
