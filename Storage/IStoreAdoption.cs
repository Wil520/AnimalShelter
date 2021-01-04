using System;

using AnimalShelter.Models;

namespace AnimalShelter.Storage
{
    public interface IStoreAdoptions
    {
        void Create(Adoption adoption);
    }
}