using System;

using AnimalShelter.Models;

namespace AnimalShelter.Storage
{
    public interface IStoreAdopters
    {
        void Create(Adopter adopter);
        Adopter GetById(Guid adopterId);
    }
}