using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogs
{
    class Dog : Animal
    {
        
        public string FavoriteBone { get; set; }
        
        public override string ToString()
        {
            return string.Format("{0} says 'woof' I am {1} and like " +
              "{2} bones", Name, Age, FavoriteBone);
        }
        public Dog(string name, int age, string bone)
        {
            Name = name;
            Age = age;
            FavoriteBone = bone;
        }

    }
}
