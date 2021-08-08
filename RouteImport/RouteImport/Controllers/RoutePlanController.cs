using Geotab.Checkmate;
using Microsoft.AspNetCore.Mvc;
using RouteImport.Models;
using RouteImport.Repositories.Abstracts;
using System;

namespace RouteImport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutePlanController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoutePlanController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public IActionResult CreateRoute([FromBody] Credentials credentials, [FromBody] FileDetails details)
        {
            try
            {
                API api = new API(credentials.Username, null, credentials.SessionId, credentials.Database, credentials.Server);
                if (!_unitOfWork.apiRepository.Aunthenticate(api))
                    return Unauthorized();
                else
                    //_unitOfWork.apiRepository.AddRoute();
                    return Ok();


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }

}
