using AspNetWebApiDemo.Repo.Models;
using System.Collections.Generic;

namespace NinjectWebApiDemo.Repo.Interfaces
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAnimals();
    }
}
