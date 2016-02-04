namespace Memento.Common
{
    public class Origin
    {
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        private Memento Memento { get; set; }

        public void RevertOrigin()
        {
            this.Street = this.Memento.Street;
            this.Zip = this.Memento.Zip;
            this.City = this.Memento.City;
        }

        public static class Factory
        {
            public static Origin CreateNewInstance(string street, string zip, string city)
            {
                return new Origin
                {
                    Street = street,
                    Zip = zip,
                    City = city,
                    Memento = new Memento(street, zip, city) 
                };
            }
        }  
    }
}
