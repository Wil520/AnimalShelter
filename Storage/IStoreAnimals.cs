using System;

using AnimalShelter.Models;

namespace AnimalShelter.Storage
{
    public interface IStoreAnimals
    {
        void Create(Animal animal);
        Animal GetById(Guid animalId);
    }
}