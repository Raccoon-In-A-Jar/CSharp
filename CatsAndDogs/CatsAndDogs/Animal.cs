using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogs
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void HaveBirthday() { Age += 1; }
    }
}
