namespace _011_Constraints
{
    class Porsche : ICar
    {
        public Porsche(string name, uint Year)
        {
            this.name = name;
            this.year = Year;
        }

        readonly string name;
        readonly uint year;

        public string Name => name;
        public uint Year => year;
    }
}
