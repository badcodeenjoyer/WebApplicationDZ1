using Interfaces;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;


namespace WebApplicationDZ1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ICheck _checkService;
        private readonly IContent _contentService;
        private readonly ILogic _logicService;
        private readonly IPublish _publishService;
        private readonly ISave _saveInfService;

        public HomeController(ICheck checkService , IContent contentService, ILogic logicService, IPublish publishService, ISave saveInfService)
        {
            _checkService = checkService;
            _contentService = contentService;
            _logicService = logicService;
            _publishService = publishService;
            _saveInfService = saveInfService;
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            var lst = new List<string>();
            
            _logicService.DoAllLogic(_publishService, _contentService, _checkService, _saveInfService);
            
            
            foreach (var item in _saveInfService.Pub())
            {
                lst.Add(item);
            }
         


            return Ok(lst);
        }
    }
}
