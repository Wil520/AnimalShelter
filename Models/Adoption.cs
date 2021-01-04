using System;

namespace AnimalShelter.Models
{
    public class Adoption
    {
        public Guid Id { get; set; }
        public Animal TheAnimal {get; set;}
        public Adopter TheAdopter {get; set;}
        public DateTime AdoptionDate {get; set;}

        public Adoption(Animal animal, Adopter adopter, DateTime adoptionDate) {
            Id = Guid.NewGuid();
            this.TheAnimal = animal;
            this.TheAdopter = adopter;
            this.AdoptionDate = adoptionDate;
        }

    }
   
}
