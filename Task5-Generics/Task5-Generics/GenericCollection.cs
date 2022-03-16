using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Generics
{
    public class GenericCollection<TObject> where TObject : class
    {
        private TObject[] objects;
        private int length;

        public GenericCollection(int number)
        {
            this.objects = new TObject[number];
            this.length = number;
        }

        public TObject Get(int position)
        {
            if (position < 0)
                throw new ArgumentOutOfRangeException("Position must be positive");
            if (position >= this.length)
                throw new ArgumentOutOfRangeException("Position is greater than length");
            return this.objects[position];
        }

        public void Set(int position, TObject newObject)
        {
            if (position < 0)
                throw new ArgumentOutOfRangeException("Position must be positive");
            if (position >= this.length)
                throw new ArgumentOutOfRangeException("Position is greater than length");
            this.objects[position] = newObject;
        }

        public void Swap(int position1, int position2)
        {
            if (position1 < 0)
                throw new ArgumentOutOfRangeException("First osition must be positive");
            if (position1 >= this.length)
                throw new ArgumentOutOfRangeException("First position is greater than length");
            if (position2 < 0)
                throw new ArgumentOutOfRangeException("Second position must be positive");
            if (position2 >= this.length)
                throw new ArgumentOutOfRangeException("Second position is greater than length");
            TObject auxiliary = this.objects[position1];
            this.objects[position1] = this.objects[position2];
            this.objects[position2] = auxiliary;
        }

        public void Swap(TObject object1, TObject object2)
        {
            if (!objects.Contains(object1))
                throw new ArgumentException("First object does not exist in collection");
            if (!objects.Contains(object2))
                throw new ArgumentException("Second object does not exist in collection");
            int position1 = 0;
            int position2 = 0;
            for (int i = 0; i < length; i++)
                if (objects[i] == object1)
                    position1 = i;
                else if (objects[i] == object2)
                    position2 = i;
            Swap(position1, position2);
        }

        public void Swap(TObject existingObject, int position)
        {
            if (!objects.Contains(existingObject))
                throw new ArgumentException("Object does not exist in collection");
            if (position < 0)
                throw new ArgumentOutOfRangeException("Position must be positive");
            if (position >= this.length)
                throw new ArgumentOutOfRangeException("Position is greater than length");
            int position1 = 0;
            for (int i = 0; i <= length; i++)
                if (objects[i] == existingObject)
                    position1 = i;
            Swap(position1, position);
        }

        public void Swap(int position, TObject existingObject)
        {
            if (!objects.Contains(existingObject))
                throw new ArgumentException("Object does not exist in collection");
            if (position < 0)
                throw new ArgumentOutOfRangeException("Position must be positive");
            if (position >= this.length)
                throw new ArgumentOutOfRangeException("Position is greater than length");
            int position2 = 0;
            for (int i = 0; i <= length; i++)
                if (objects[i] == existingObject)
                    position2 = i;
            Swap(position, position2);
        }
    }
}
