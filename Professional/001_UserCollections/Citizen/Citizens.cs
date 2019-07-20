using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizen
{
    abstract class Citizen
    {
        public Citizen(string name)
        {
            this.name = name;
        }

        protected virtual int passportID => name.GetHashCode();

        protected string name;

        public abstract string Name { get; }

        public override int GetHashCode()
        {
            return passportID;
        }

        public override bool Equals(object obj)
        {
            Citizen temp = obj as Citizen;
            if (temp == null)
                return false;
            return name == temp.name;
        }

        public static bool operator ==(Citizen c1, Citizen c2)
        {
            if (((object)c1) == null || ((object)c2) == null)
                return false;
            return c1.GetHashCode() == c2.GetHashCode() && c1.Equals(c2);
        }

        public static bool operator !=(Citizen c1, Citizen c2)
        {
            if (((object)c1) == null || ((object)c2) == null)
                return true;
            return c1.GetHashCode() != c2.GetHashCode() || !c1.Equals(c2);
        }
    }

    class Student : Citizen
    {
        public Student(string name) : base(name) { }

        public override string Name => name;

        public override bool Equals(object obj)
        {
            Student temp = obj as Student;
            if (temp == null)
                return false;
            return passportID == temp.passportID;
        }
    }

    class Pensioner : Citizen
    {
        public Pensioner(string name) : base(name) { }

        public override string Name => name;

        public override bool Equals(object obj)
        {
            Pensioner temp = obj as Pensioner;
            if (temp == null)
                return false;
            return passportID == temp.passportID;
        }
    }

    class Worker : Citizen
    {
        public Worker(string name) : base(name) { }

        public override string Name => name;

        public override bool Equals(object obj)
        {
            Worker temp = obj as Worker;
            if (temp == null)
                return false;
            return passportID == temp.passportID;
        }
    }
}
