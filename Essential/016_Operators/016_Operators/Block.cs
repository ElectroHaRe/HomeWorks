namespace _016_Operators
{
    class Block
    {
        int a, b, c, d;

        public Block(int a, int b , int c , int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static Block operator +(Block b1, Block b2)
        {
            return new Block(b1.a + b2.a, b2.b + b1.b, b1.c + b2.c, b1.d + b2.d);
        }

        public override bool Equals(object obj)
        {
            Block temp = obj as Block;

            if (temp == null)
                return false;

            return a == temp.a && b == temp.b && c == temp.c && d == temp.d;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return " [ " + a + " , " + b + " , " + c + " ]";
        }
    }
}
