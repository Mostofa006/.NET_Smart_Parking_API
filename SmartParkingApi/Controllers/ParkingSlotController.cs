using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartParkingApi.Controllers
{
    public class ParkingSlotController : ApiController
    {
        [HttpGet]
        [Route("parkingslot/user")]

        public HttpResponseMessage Get()
        {
            try
            {
                var data = ParkingSlotService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
