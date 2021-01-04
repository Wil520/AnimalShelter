using System;
using System.Collections.Generic;

using AnimalShelter.Models;

namespace AnimalShelter.Storage
{
    public class AdoptionStoreList: IStoreAdoptions
    {

        private List<Adoption> _adoptions;


        public AdoptionStoreList() {
            _adoptions = new List<Adoption>();
        }        

        public void Create(Adoption adoption) {
            _adoptions.Add(adoption);

        } 
    }
}