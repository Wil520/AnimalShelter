using System;

namespace AnimalShelter.Models
{
    public class Adopter
    {

        public Adopter(string firstName, string lastName) {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }

        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
   
}
