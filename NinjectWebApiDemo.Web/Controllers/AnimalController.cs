using NinjectWebApiDemo.Repo.Interfaces;
using System.Web.Http;

namespace AspNetWebApiDemo.Controllers
{
    public class AnimalController : ApiController
    {
        protected readonly IAnimalRepository repository;

        public AnimalController(IAnimalRepository repository)
        {
            this.repository = repository;
        }

        public IHttpActionResult GetAnimals()
        {
            var animals = repository.GetAnimals();
            return Json(animals);
        }
    }
}
