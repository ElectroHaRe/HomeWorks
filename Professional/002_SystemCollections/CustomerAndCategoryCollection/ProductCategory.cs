namespace CustomerAndCategoryCollection
{
    class ProductCategory
    {
        public ProductCategory(string name, int id)
        {
            Id = id;
            Name = name;
        }

        public readonly string Name;
        public readonly int Id;

        public override string ToString()
        {
            return Name + " [ id = " + Id.ToString() + " ]";
        }

        public override bool Equals(object obj)
        {
            if (obj is ProductCategory)
                return Name == ((ProductCategory)obj).Name && Id == ((ProductCategory)obj).Id;
            else return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
