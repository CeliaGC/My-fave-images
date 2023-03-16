using API.IServices;
using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;

using System.Security.Authentication;
using System.Web.Http.Cors;

namespace Apii.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {

        private readonly IImageService _imageService;
        private readonly ServiceContext _serviceContext;

        public ProductController(IImageService imageService, ServiceContext serviceContext)
        {
            _imageService = imageService;
            _serviceContext = serviceContext;

        }

        [HttpPost(Name = "InsertImage")]
        public int Post([FromBody] ImageItem imageItem)
        {
           
                return _imageService.InsertImage(imageItem);
        }

        [HttpDelete(Name = "DeleteImage")]
        public void Delete([FromQuery] int Id)
        {

                _imageService.DeleteImage(Id);

        }

        [HttpPatch(Name = "ModifyImage")]
        public void Patch([FromBody] ImageItem imageItem)

        {
                _imageService.UpdateImage(imageItem);
    
        }

        [HttpGet(Name = "GetImagesByCriteria")]
        public List<ImageItem> GetImageByCriteria([FromQuery] string Category)
        {

            return _imageService.GetImageByCriteria(Category);
        }

        [HttpGet(Name = "GetAllImages")]
        public List<ImageItem> GetAll()
        {

            return _imageService.GetAll();
        }
    }
}

