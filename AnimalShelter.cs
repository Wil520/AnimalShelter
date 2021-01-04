using System;
using System.Collections.Generic;

using AnimalShelter.Models;
using AnimalShelter.Storage;

namespace AnimalShelter
{
    public class AnimalShelterSystem
    {

        /*** Storage ***/
        private IStoreAnimals _animalStorage;
        private IStoreAdopters _adopterStorage;
        private IStoreAdoptions _adoptionStorage;


        public AnimalShelterSystem(IStoreAnimals animalStorageArg,
            IStoreAdopters adopterStorageArg,
            IStoreAdoptions adoptionStorageArg)
        {

            _animalStorage = animalStorageArg;
            _adopterStorage = adopterStorageArg;
            _adoptionStorage = adoptionStorageArg;

            var dog1 = new Dog("Charlie", "M", "white");

            _animalStorage.Create(dog1);

            var adopter = new Adopter("Will", "G");

            _adopterStorage.Create(adopter);

        }

        public Adoption Adopt(Guid aimalId, Guid adopterId)
        {

            var animal = _animalStorage.GetById(aimalId);
            var adopter = _adopterStorage.GetById(adopterId);

            var adoption = new Adoption(animal, adopter, DateTime.Now);


            _adoptionStorage.Create(adoption);

            return adoption;
        }


    }

}
