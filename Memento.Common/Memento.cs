namespace Memento.Common
{
    public class Memento
    {
        public string Street { get; private set; }
        public string Zip { get; private set; }
        public string City { get; private set; }

        public Memento(string street, string zip, string city)
        {
            this.Street = street;
            this.Zip = zip;
            this.City = city;
        }
    }
}

