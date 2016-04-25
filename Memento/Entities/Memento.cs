namespace Memento.Entities
{
    public class Memento
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Memento() { }

        public Memento(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
