using System;

namespace _007_Attributes
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = false,Inherited =false)]
    class AccessLevelAttribute:Attribute
    {
        public enum AccessLevel {low,normal,hard }

        public AccessLevel Level { get; private set; }

        public AccessLevelAttribute(AccessLevel level)
        {
            Level = level;
        }
    }
}
