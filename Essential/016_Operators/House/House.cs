using System;

namespace House
{
    class House
    {
        Object obj = new object();

        public House Clone()
        {
            return new House();
        }

        public House DeepClone()
        {
            return (House)((this.MemberwiseClone() as House).obj = new object());
        }
    }
}
