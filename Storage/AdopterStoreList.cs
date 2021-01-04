using System;
using System.Collections.Generic;

using AnimalShelter.Models;

namespace AnimalShelter.Storage
{
    public class AdopterStoreList: IStoreAdopters
    {

        private List<Adopter> _adopters;


        public AdopterStoreList() {
            _adopters = new List<Adopter>();
        }        

        public void Create(Adopter Adopter) {
            _adopters.Add(Adopter);

        }
        public Adopter GetById(Guid adopterId) {
            var adopter = _adopters.Find(x => x.Id == adopterId);

            if (adopter == null) {
                throw new Exception($"Adopter {adopterId} not found!");
            }
            return adopter;
        }       
    }
}