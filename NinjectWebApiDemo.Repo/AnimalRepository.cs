using AspNetWebApiDemo.Repo.Models;
using NinjectWebApiDemo.Repo.Interfaces;
using System.Collections.Generic;

namespace NinjectWebApiDemo.Repo
{
    public class AnimalRepository : IAnimalRepository
    {
        public IEnumerable<Animal> GetAnimals()
        {
            var animals = new List<Animal>() {
                new Animal() { Name = "Dog", Description = "A dog. " },
                new Animal() { Name = "Cat", Description = "A cat! " },
                new Animal() { Name = "Bird", Description = "A bird. " }
            };
            return animals;
        }
    }
}
