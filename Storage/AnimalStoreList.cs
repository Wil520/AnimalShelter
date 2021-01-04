using System;
using System.Collections.Generic;

using AnimalShelter.Models;

namespace AnimalShelter.Storage
{
    public class AnimalStoreList: IStoreAnimals
    {

        private List<Animal> _animals;


        public AnimalStoreList() {
            _animals = new List<Animal>();
        }        

        public void Create(Animal animal) {
            _animals.Add(animal);

        }
        public Animal GetById(Guid animalId) {
            var animal = _animals.Find(x => x.Id == animalId);

            if (animal == null) {
                throw new Exception($"Animal {animalId} not found!");
            }
            return animal;
        }       
    }
}