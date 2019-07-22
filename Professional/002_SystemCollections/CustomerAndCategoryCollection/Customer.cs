namespace CustomerAndCategoryCollection
{
    class Customer
    {
        public Customer(string first_name, string second_name)
        {
            FirstName = first_name;
            SecondName = second_name;
        }

        public readonly string FirstName;
        public readonly string SecondName;

        public override string ToString()
        {
            return FirstName + " " + SecondName;
        }

        public override bool Equals(object obj)
        {
            if (obj is Customer)
                return FirstName == ((Customer)obj).FirstName && SecondName == ((Customer)obj).SecondName;
            else return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
