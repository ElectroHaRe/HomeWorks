namespace Magazine
{
    class Article
    {
        public Article(string name, string shop, string cost) {
            this.name = name;
            this.shop = shop;
            this.cost = cost;
        }

        public readonly string name;
        public readonly string shop;
        public readonly string cost;
    }
}
