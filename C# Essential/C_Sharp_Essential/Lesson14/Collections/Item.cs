namespace Collections
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Prise { get; set; }

        public Item(int id, string name, double prise)
        {
            Id = id;
            Name = name;
            Prise = prise;
        }

    }
}
