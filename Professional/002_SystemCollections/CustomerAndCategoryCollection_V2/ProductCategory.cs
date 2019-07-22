namespace CustomerAndCategoryCollection_V2
{
    class ProductCategory
    {
        public ProductCategory(string name, int id)
        {
            Name = name;
            this.id = id;
        }

        public readonly string Name;
        public readonly int id;

        public override string ToString()
        {
            return Name + " [ id : " + id + " ]";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is ProductCategory)
                return Name == ((ProductCategory)obj).Name && ((ProductCategory)obj).id == id;
            return false;
        }
    }
}
