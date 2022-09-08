using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogs
{
    class Cat : Animal
    {
        
        public string FavoriteFish { get; set; }
        
        public override string ToString()
        {
            return string.Format("{0} says 'Meow' I am {1} and like " +
              "{2}", Name, Age, FavoriteFish);
        }
        public Cat(string name, int age, string fish)
        {
            Name = name;
            Age = age;
            FavoriteFish = fish;
        }
    }
}
