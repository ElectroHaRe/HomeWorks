namespace CustomerAndCategoryCollection_V2
{
    class Customer
    {
        public Customer(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public readonly string FirstName;
        public readonly string LastName;

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public override bool Equals(object obj)
        {
            if (obj is Customer)
                return FirstName == ((Customer)obj).FirstName && LastName == ((Customer)obj).LastName;
            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
