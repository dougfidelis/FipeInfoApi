using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace fipeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FipeInfoController : ControllerBase
    {
        public FipeInfoRepository repository;

        public FipeInfoController()
        {
            repository = new FipeInfoRepository();
        }
        [HttpGet]
        public List<FipeInfo> Get()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public string Post(FipeInfo model)
        {
            return repository.Create(model);
        }
    }



}

