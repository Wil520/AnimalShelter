using System;

namespace AnimalShelter
{
    public class Animal
    {

        public long Id { get; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
        public bool IsAdopted { get; set; }


        public Animal(long id, string name, string sex, string color)
        {
            this.Id = id;
            this.Name = name;
            this.Sex = sex;
            this.Color = color;
        }

    }
   
}
