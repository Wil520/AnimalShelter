using System;
using System.Collections.Generic;

namespace AnimalShelter
{
    public class AnimalShelterSystem
    {

        private List<Animal> _animals;
        private List<Patron> _patrons;

        public AnimalShelterSystem() {
            _animals = new List<Animal>();
            _patrons = new List<Patron>();

            var dog1 = new Dog(1, "Charlie", "M", "white");

            _animals.Add(dog1);
            
            var patron1 = new Patron(1, "Will", "G");

            _patrons.Add(patron1);

        }

    }
   
}
