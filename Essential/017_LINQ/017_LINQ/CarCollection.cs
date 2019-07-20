using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _017_LINQ
{
    class CarCollection : IEnumerable<CarCollection.Car>, IEnumerator<CarCollection.Car>
    {
        public class Car
        {
            public Car(string make, string model, string year, string color)
            {
                this.make = make; this.model = model; this.year = year; this.color = color;

                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].make == make && cars[i].model == model && cars[i].year == year && cars[i].color == color)
                    {
                        id = cars[i].GetHashCode();
                    }
                }

                id = this.GetHashCode();
                Array.Resize(ref cars, cars.Length + 1);
                cars[cars.Length - 1] = this;
            }

            private static Car[] cars = new Car[0];

            private readonly int id;

            public readonly string make;
            public readonly string model;
            public readonly string year;
            public readonly string color;

            public override bool Equals(object obj)
            {
                Car temp = obj as Car;

                if (temp == null)
                    return false;

                if (temp.make == make && temp.model == model && temp.year == year && temp.color == color)
                    return true;
                else return false;
            }

            public override int GetHashCode()
            {
                return id;
            }

            public override string ToString()
            {
                return "maker : " + make + " | model : " + model + " | year : " + year + " | color : " + color;
            }
        }

        private Car[] collection = new Car[0];

        public int size => collection.Length;

        public Car this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                    return null;
                else return collection[index];
            }
        }

        public Car[] this[Predicate<Car> predicate]
        {
            get
            {
                Car[] temp = new Car[0];
                for (int i = 0; i < size; i++)
                {
                    if (predicate(collection[i]))
                    {
                        Array.Resize(ref temp, temp.Length+1);
                        temp[temp.Length - 1] = collection[i];
                    }
                }
                return temp;
            }
        }

        public void AddCar(string make, string model, string year, string color)
        {
            AddCar(new Car(make, model, year, color));
        }

        public void AddCar(Car item)
        {
            Array.Resize(ref collection, size + 1);
            collection[size - 1] = item;
        }

        public void AddCar(params Car[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                AddCar(items[i]);
            }
        }

        public bool DeleteCar(Car car)
        {
            if (!collection.Contains(car))
                return false;

            Car[] temp = new Car[size-1];
            int j = 0;
            for (int i = 0; i < size-1; i++)
            {
                if (collection[i].Equals(car))
                    j = 1;
                temp[i] = collection[i + j];
            }

            collection = temp;

            return true;
        }

        public bool DeleteCar(string make, string model, string year, string color)
        {
            return DeleteCar(new Car(make, model, year, color));
        }

        public void DeleteCars(params Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                DeleteCar(cars[i]);
            }
        }

        // // // // // // // // // // // // // // // // // //

        public int position { get; private set; } = -1;

        Car IEnumerator<Car>.Current
        {
            get
            {
                if (position < 0 || position >= size)
                    return null;
                else return collection[position];
            }
        }

        object IEnumerator.Current => ((IEnumerator<Car>)this).Current;

        IEnumerator<Car> IEnumerable<Car>.GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        bool IEnumerator.MoveNext()
        {
            if (position < size - 1)
            {
                position++;
                return true;
            }
            else
            {
                ((IEnumerator<Car>)this).Reset();
                return false;
            }
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }

        void IDisposable.Dispose()
        {
        }
    }
}
