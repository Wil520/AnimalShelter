using System;

namespace AnimalShelter.Models
{
    public class Animal
    {

        public Guid Id { get; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
        public bool IsAdopted { get; set; }


        public Animal(string name, string sex, string color)
        {
            Id = Guid.NewGuid();
            this.Name = name;
            this.Sex = sex;
            this.Color = color;
        }

    }
   
}
