namespace Memento.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Memento Memento = new Memento();

        public Customer()
        {
            Id = 1;
            Name = "DDD";
            Memento = new Memento(Id, Name);
        }

        public void Revert()
        {
            Id = Memento.Id;
            Name = Memento.Name;
        }
    }
}
