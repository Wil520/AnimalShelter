using System;

namespace AnimalShelter
{
    public class Adoption
    {

        public Animal TheAnimal {get; set;}
        public Patron ThePatron {get; set;}
        public DateTime AdoptionDate {get;}

        public Adoption(Animal animal, Patron patron, DateTime adoptionDate) {
            this.TheAnimal = animal;
            this.ThePatron = patron;
            this.AdoptionDate = adoptionDate;
        }

    }
   
}
